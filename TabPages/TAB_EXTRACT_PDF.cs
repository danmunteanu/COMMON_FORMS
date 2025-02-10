using SharpCompress;

namespace CommonForms
{
    //public abstract class ActionSetter<TAction>
    //{
    //    private TAction? _action;

    //    public abstract void OnActionSet();

    //    TAction? Action {  
    //        get { return _action; } 
    //        set { _action = value; OnActionSet(); }
    //    }
    //}

    public partial class TAB_EXTRACT_PDF : ApplicationPageBase
    {
        public ActionExtractPDFPages? Action { get; set; } = null;

        private string DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        private const string K_OUPUT_FILENAME_MASK = "EXTRACT-PAGES-{0}";
        public const string K_DATE_MASK = "yyyy-MM-dd hh:mm tt";

        private int mPageCount = 0;

        private List<int> mPagesToExclude = new()
        {
            //4, 7, 9, 11, 13,
            //15, 19, 22, 24,
            //26, 29, 31, 33,
            //35, 38, 41, 43,
            //46, 48, 50, 52,
            //54, 56, 57, 58,
            //59, 60
        };

        public bool AdvancedMode { get; set; } = false;

        public TAB_EXTRACT_PDF()
        {
            InitializeComponent();

            Label lblDragHere = new Label
            {
                Name = "lblDragHere",
                Text = "You can drag and drop PDF files here.",
                AutoSize = false, // Allows manual sizing
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill, // Ensures it stays centered
                Font = new Font("Arial", 12, FontStyle.Italic | FontStyle.Bold),
                ForeColor = Color.Gray
            };
            AdvancedMode = false;

            // Add label to panel
            panelDrag.Controls.Add(lblDragHere);

            UpdateUI();
            UpdateStatus(string.Empty);
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void OnKeyPressed(TextBox textControl, KeyPressEventArgs evt)
        {
            char keyChar = evt.KeyChar;

            // Replace selected text if there is a selection
            if (textControl.SelectionLength > 0 && !char.IsControl(keyChar))
            {
                int selectionStart = textControl.SelectionStart;
                int selectionLength = textControl.SelectionLength;

                // Remove the selected text and insert the new character
                textControl.Text = textControl.Text.Remove(selectionStart, selectionLength)
                                              .Insert(selectionStart, keyChar.ToString());

                // Move cursor to the position after the inserted character
                textControl.SelectionStart = selectionStart + 1;
                evt.Handled = true; // Mark event as handled to prevent further processing
                return;
            }

            // Allow control characters (backspace, delete, etc.)
            if (char.IsControl(keyChar))
            {
                return;
            }

            // Allow digits and validate range
            if (char.IsDigit(keyChar))
            {
                string currentText = textControl.Text + keyChar;
                if (!IsValidPageRange(currentText))
                {
                    evt.Handled = true;
                }
                return;
            }

            // Allow comma with specific rules
            if (keyChar == ',')
            {
                if (textControl.Text.Length == 0 || textControl.Text.EndsWith(",") || textControl.Text.EndsWith(", "))
                {
                    evt.Handled = true;
                }
                return;
            }

            // Allow hyphen for page ranges with specific rules
            if (keyChar == '-')
            {
                if (textControl.Text.Length == 0 || !char.IsDigit(textControl.Text[^1]) || textControl.Text.EndsWith("-") || textControl.Text.EndsWith(","))
                {
                    evt.Handled = true;
                }
                return;
            }

            // Allow space only if it's immediately after a comma
            if (char.IsWhiteSpace(keyChar) && !textControl.Text.EndsWith(","))
            {
                evt.Handled = true;
            }
            else
            {
                evt.Handled = true;
            }
        }

        private void txtPages_KeyPress(object sender, KeyPressEventArgs evt)
        {
            OnKeyPressed(txtPages, evt);
        }


        // Helper method to check if each page/range is within the allowed limits
        private bool IsValidPageRange(string input)
        {
            string[] parts = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                if (part.Contains("-"))
                {
                    var range = part.Split('-');
                    if (range.Length == 2 &&
                        int.TryParse(range[0], out int start) &&
                        int.TryParse(range[1], out int end))
                    {
                        // Ensure both start and end are within page limits
                        if (start < 1 || start > mPageCount || end < 1 || end > mPageCount)
                        {
                            return false; // Page numbers must be within valid range
                        }
                    }
                    else
                    {
                        return false; // Invalid range format
                    }
                }
                else if (int.TryParse(part, out int page))
                {
                    // Check if the single page number is within limits
                    if (page < 1 || page > mPageCount)
                    {
                        return false;
                    }
                }
                else
                {
                    return false; // Non-numeric entry
                }
            }
            return true;
        }

        public override void UpdateUI()
        {
            bool pdfSelected = !string.IsNullOrEmpty(txtDocument.Text);
            bool pagesEntered = !string.IsNullOrEmpty(txtPages.Text);

            txtPages.Enabled = pdfSelected;
            btnClearPages.Enabled = pdfSelected;
            txtExclude.Enabled = pdfSelected;

            if (!pdfSelected)
            {
                lblPageCount.Text = "No document loaded.";
            }
            else
            {
                //  TODO: CountPages should not be called on each UpdateUI();
                mPageCount = ActionExtractPDFPages.CountPages(txtDocument.Text);
                lblPageCount.Text = string.Format("Has {0} page(s).", mPageCount);
                txtPages.PlaceholderText = string.Format("Enter page numbers (or intervals) between 1 and {0}", mPageCount);
            }

            chkAllowDuplicates.Enabled = pdfSelected;
            chkOnlyOdd.Enabled = pdfSelected;
            chkOnlyEven.Enabled = pdfSelected;
            btnReload.Enabled = pdfSelected;
            btnExtract.Enabled = pdfSelected /* && pagesEntered */;

            if (AdvancedMode)
                btnAdvanced.Text = "SIMPLE";
            else
                btnAdvanced.Text = "ADVANCED";

            btnReload.Visible = AdvancedMode;
            chkAllowDuplicates.Visible = AdvancedMode;
            lblExclude.Visible = AdvancedMode;
            txtExclude.Visible = AdvancedMode;
            btnClearExclude.Visible = AdvancedMode;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (Action == null)
            {
                UpdateStatus("Action is not set.");
                return;
            }

            string input = txtPages.Text.TrimEnd(',', ' ');

            if (input.Length <= 0)
            {
                UpdateStatus("Please enter one or more page numbers.");
                txtPages.Focus();
                return;
            }

            using (SaveFileDialog dlgSave = new SaveFileDialog())
            {
                dlgSave.Filter = "PDF files (*.pdf)|*.pdf";
                dlgSave.DefaultExt = "PDF";
                dlgSave.AddExtension = true;
                dlgSave.Title = "Select Destination PDF";
                dlgSave.FileName = GenerateDestinationFileName(txtDocument.Text);
                dlgSave.InitialDirectory = DESKTOP_PATH;

                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    string[] parts = input.Split(',');

                    List<int> numbers = new();
                    foreach (var part in parts)
                    {
                        string trimmedPart = part.Trim();

                        if (trimmedPart.Contains("-"))
                        {
                            // Handle page range
                            var range = trimmedPart.Split('-');
                            if (int.TryParse(range[0], out int start) && int.TryParse(range[1], out int end))
                            {
                                if (start <= end)
                                {
                                    // Ascending range, e.g., 1-5
                                    for (int i = start; i <= end; i++)
                                        AddNumber(numbers, i);
                                }
                                else
                                {
                                    // Descending range, e.g., 200-193
                                    for (int i = start; i >= end; i--)
                                        AddNumber(numbers, i);
                                }
                            }
                        }
                        else if (int.TryParse(trimmedPart, out int page))
                        {
                            // Single page entry
                            AddNumber(numbers, page);
                        }
                    }

                    // Pass required fields to action
                    Action.Pages = numbers.Except(mPagesToExclude).ToList();
                    Action.Destination = dlgSave.FileName;
                    Action.Execute(txtDocument.Text);

                    UpdateStatus("Selected pages have been extracted.");
                    UpdateUI();

                    btnExtract.Enabled = false;
                }
            }
        }

        private void AddNumber(List<int> numbers, int num)
        {
            if (chkOnlyOdd.Checked)
            {
                //  add only if odd
                if (num % 2 == 0)
                    numbers.Add(num);
            }
            else if (chkOnlyEven.Checked)
            {
                //  add only if even
                if (num % 2 != 0)
                    numbers.Add(num);
            }
            else
            {
                //  add all
                numbers.Add(num);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //  Select Source
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = "PDF files (*.pdf)|*.pdf";// mResourceManager.GetString("SAVE_DIALOG_FILTER");
                dlgOpen.DefaultExt = "PDF";// mResourceManager.GetString("SAVE_DIALOG_EXT");
                dlgOpen.AddExtension = true;
                dlgOpen.Title = "Select Source (PDF)";// mResourceManager.GetString("SAVE_DIALOG_TITLE");
                dlgOpen.InitialDirectory = DESKTOP_PATH;

                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    txtDocument.Text = dlgOpen.FileName;

                    //  clear the fields
                    txtPages.Clear();
                    txtExclude.Clear();

                    UpdateStatus("Document selected.");

                    UpdateUI();

                    txtPages.Select();
                }
            }
        }

        private string GenerateDestinationFileName(string sourceName)
        {
            string outputName = string.Empty;
            if (string.IsNullOrEmpty(sourceName))
            {
                //  EXTRACT + DATE
                outputName = string.Format(K_OUPUT_FILENAME_MASK, DateTime.Now.ToString(K_DATE_MASK));
            }
            else
            {
                //  Get Name

                string simpleFileName = Path.GetFileName(sourceName);

                //  Append EXTRACT-{FileName}
                outputName = string.Format("ExtractPages-{1}", DateTime.Now.ToString(K_DATE_MASK), simpleFileName);
            }

            return outputName;
        }

        private void btnClearPages_Click(object sender, EventArgs e)
        {
            txtPages.Clear();
            txtPages.Select();
        }

        public override void UpdateLocale()
        {
            //  update string localizations
        }

        private void btnSelectDoc_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is a file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && Path.GetExtension(files[0]).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy; // Allow the drop
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Deny the drop
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnSelectDoc_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            // Get the dragged files
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length > 0)
                {
                    string pdfFilePath = files[0];
                    //MessageBox.Show($"PDF file dropped: {pdfFilePath}", "File Dropped", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDocument.Text = pdfFilePath;

                    //  clear the fields
                    txtPages.Clear();

                    UpdateStatus("Document selected.");

                    UpdateUI();

                    txtPages.Select();

                }
            }
        }

        private void chkOnlyOdd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnlyOdd.Checked)
                chkOnlyEven.Checked = false;
        }

        private void chkOnlyEven_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnlyEven.Checked)
                chkOnlyOdd.Checked = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocument.Text))
                return;

            //  clear the fields
            txtPages.Clear();

            UpdateStatus("Document reloaded.");

            UpdateUI();

            txtPages.Select();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            AdvancedMode = !AdvancedMode;
            UpdateUI();
        }

        private void btnClearExclude_Click(object sender, EventArgs e)
        {
            txtExclude.Clear();
        }

        private void txtExclude_KeyPress(object sender, KeyPressEventArgs evt)
        {
            OnKeyPressed(txtExclude, evt);
        }
    }
}

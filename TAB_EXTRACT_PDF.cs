using SharpCompress;

namespace CommonForms
{
    public partial class TAB_ExtractPDF : ApplicationPageBase
    {
        public ActionExtractPDFPages Action { get; set; }

        private string DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        public const string K_DATE_MASK = "yyyy-MM-dd hh:mm tt";

        public int mPageCount = 0;

        public TAB_ExtractPDF()
        {
            InitializeComponent();

            UpdateUI();
            UpdateStatus("");
        }

        private new void UpdateStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            // Allow control characters (backspace, delete, etc.)
            if (char.IsControl(keyChar))
            {
                //ReloadUI();
                return;
            }

            // Allow digits
            if (char.IsDigit(keyChar))
            {
                // Validate the current number after the digit is entered
                string currentText = txtPages.Text + keyChar;

                if (!IsValidPageRange(currentText))
                {
                    e.Handled = true; // Block input if out of range
                }
                //ReloadUI();
                return;
            }

            // Allow comma, but ensure it's not the first character or after another comma
            if (keyChar == ',')
            {
                if (txtPages.Text.Length == 0 || txtPages.Text.EndsWith(",") || txtPages.Text.EndsWith(", "))
                {
                    e.Handled = true; // Block the input
                }
                //ReloadUI();
                return;
            }

            // Allow hyphen for page ranges, but only between numbers
            if (keyChar == '-')
            {
                if (txtPages.Text.Length == 0 || !char.IsDigit(txtPages.Text[^1]) || txtPages.Text.EndsWith("-") || txtPages.Text.EndsWith(","))
                {
                    e.Handled = true; // Block invalid hyphen placements
                }
                //ReloadUI();
                return;
            }

            // Allow space, but only if it's immediately after a comma
            if (char.IsWhiteSpace(keyChar))
            {
                if (txtPages.Text.EndsWith(","))
                {
                    //ReloadUI();
                    return;
                }
                else
                {
                    e.Handled = true; // Block spaces that are not after a comma
                }
            }
            else
            {
                // Block any other non-digit, non-comma, non-space, non-hyphen characters
                e.Handled = true;
            }
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
                        // Check if the range is within the allowed limits
                        if (start < 1 || end > mPageCount || start > end)
                        {
                            return false;
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
            bool pdfSelected = !string.IsNullOrEmpty(txtSource.Text);
            bool pagesEntered = !string.IsNullOrEmpty(txtPages.Text);

            txtPages.Enabled = pdfSelected;
            btnClearPages.Enabled = pdfSelected;

            if (!pdfSelected)
            {
                lblPageCount.Text = "No document loaded.";
            }
            else
            {
                mPageCount = ActionExtractPDFPages.CountPages(txtSource.Text);
                lblPageCount.Text = string.Format("Has {0} page(s).", mPageCount);
                txtPages.PlaceholderText = string.Format("Enter page numbers (or intervals) between 1 and {0}", mPageCount);
            }

            chkAllowDuplicates.Enabled = pdfSelected;
            btnExtract.Enabled = pdfSelected /* && pagesEntered */;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            // Step 1: Trim trailing commas and spaces
            string input = txtPages.Text.TrimEnd(',', ' ');

            if (input.Length <= 0)
            {
                UpdateStatus("Please enter one or more page numbers.");
                return;
            }

            // Select Destination
            using (SaveFileDialog dlgSave = new SaveFileDialog())
            {
                dlgSave.Filter = "PDF files (*.pdf)|*.pdf";
                dlgSave.DefaultExt = "PDF";
                dlgSave.AddExtension = true;
                dlgSave.Title = "Select Destination PDF";
                dlgSave.FileName = GenerateDestinationFileName(txtSource.Text);
                dlgSave.InitialDirectory = DESKTOP_PATH;

                // If OK pressed
                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    // Step 2: Split the input by commas
                    string[] parts = input.Split(',');

                    // Step 3: Parse parts into a list of integers, handling individual numbers and ranges
                    List<int> pagesToExtract = new List<int>();
                    foreach (var part in parts)
                    {
                        string trimmedPart = part.Trim(); // Trim spaces around the input

                        if (trimmedPart.Contains("-"))
                        {
                            // Handle ranges (e.g., "1-5")
                            var range = trimmedPart.Split('-');
                            if (range.Length == 2 &&
                                int.TryParse(range[0], out int start) &&
                                int.TryParse(range[1], out int end))
                            {
                                if (start <= end) // Ensure range is valid
                                {
                                    for (int i = start; i <= end; i++)
                                    {
                                        if (i > 0 && i <= mPageCount) // Ensure each page is within the allowed range
                                        {
                                            pagesToExtract.Add(i);
                                        }
                                    }
                                }
                            }
                        }
                        else if (int.TryParse(trimmedPart, out int singlePage))
                        {
                            // Handle single page numbers
                            if (singlePage > 0 && singlePage <= mPageCount) // Ensure page is within allowed range
                            {
                                pagesToExtract.Add(singlePage);
                            }
                        }
                    }

                    // Pass required fields to action
                    if (chkAllowDuplicates.Checked)
                        Action.Pages = pagesToExtract.ToArray();
                    else
                        Action.Pages = pagesToExtract.Distinct().OrderBy(p => p).ToArray(); // Remove duplicates and sort
                    
                    Action.Destination = dlgSave.FileName;
                    Action.Execute(txtSource.Text);

                    btnExtract.Enabled = false;

                    UpdateStatus("Selected pages extracted.");
                    UpdateUI();
                }
            }
        }


        private void btnSource_Click(object sender, EventArgs e)
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
                    txtSource.Text = dlgOpen.FileName;

                    //  clear the fields
                    txtPages.Clear();

                    UpdateStatus("Source document selected.");

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
                outputName = string.Format("EXTRACT-PAGES-{0}", DateTime.Now.ToString(K_DATE_MASK));
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

        private void btnDest_Click(object sender, EventArgs e)
        {
        }

        private void btnClearPages_Click(object sender, EventArgs e)
        {
            txtPages.Clear();
            txtPages.Select();
        }
    }
}

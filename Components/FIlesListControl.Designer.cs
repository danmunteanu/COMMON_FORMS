namespace CommonForms
{
    partial class FilesListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutFiles = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblAddFiles = new Label();
            btnSelectDesel = new Button();
            progressBar = new ProgressBar();
            lstFiles = new ListBox();
            tableLayoutRowButtons = new TableLayoutPanel();
            btnReload = new Button();
            btnAdd = new Button();
            btnRem = new Button();
            btnClear = new Button();
            lblStatus = new Label();
            tableLayoutAddOptions = new TableLayoutPanel();
            chkAddFolders = new CheckBox();
            chkParseSubfolders = new CheckBox();
            mFolderBrowserDialog = new FolderBrowserDialog();
            tableLayoutFiles.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutRowButtons.SuspendLayout();
            tableLayoutAddOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutFiles
            // 
            tableLayoutFiles.ColumnCount = 1;
            tableLayoutFiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFiles.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutFiles.Controls.Add(progressBar, 0, 4);
            tableLayoutFiles.Controls.Add(lstFiles, 0, 1);
            tableLayoutFiles.Controls.Add(tableLayoutRowButtons, 0, 5);
            tableLayoutFiles.Controls.Add(lblStatus, 0, 3);
            tableLayoutFiles.Controls.Add(tableLayoutAddOptions, 0, 2);
            tableLayoutFiles.Dock = DockStyle.Fill;
            tableLayoutFiles.Location = new Point(0, 0);
            tableLayoutFiles.Margin = new Padding(4);
            tableLayoutFiles.Name = "tableLayoutFiles";
            tableLayoutFiles.RowCount = 6;
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutFiles.Size = new Size(556, 721);
            tableLayoutFiles.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel1.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSelectDesel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(550, 34);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // lblAddFiles
            // 
            lblAddFiles.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAddFiles.AutoSize = true;
            lblAddFiles.Location = new Point(4, 4);
            lblAddFiles.Margin = new Padding(4, 0, 4, 0);
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.Size = new Size(225, 25);
            lblAddFiles.TabIndex = 26;
            lblAddFiles.Text = "↓↓ Add Files To Merge ↓↓";
            // 
            // btnSelectDesel
            // 
            btnSelectDesel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDesel.Font = new Font("Segoe UI", 7F);
            btnSelectDesel.Location = new Point(426, 3);
            btnSelectDesel.Name = "btnSelectDesel";
            btnSelectDesel.Size = new Size(121, 28);
            btnSelectDesel.TabIndex = 27;
            btnSelectDesel.Text = "SELECT ALL";
            btnSelectDesel.UseVisualStyleBackColor = true;
            btnSelectDesel.Click += btnSelectDesel_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(4, 611);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(548, 40);
            progressBar.TabIndex = 35;
            // 
            // lstFiles
            // 
            lstFiles.AllowDrop = true;
            lstFiles.Dock = DockStyle.Fill;
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 25;
            lstFiles.Location = new Point(2, 44);
            lstFiles.Margin = new Padding(2, 4, 2, 4);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(552, 468);
            lstFiles.TabIndex = 18;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.DragEnter += listFiles_DragEnter;
            // 
            // tableLayoutRowButtons
            // 
            tableLayoutRowButtons.ColumnCount = 5;
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutRowButtons.Controls.Add(btnReload, 1, 0);
            tableLayoutRowButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutRowButtons.Controls.Add(btnRem, 2, 0);
            tableLayoutRowButtons.Controls.Add(btnClear, 4, 0);
            tableLayoutRowButtons.Dock = DockStyle.Fill;
            tableLayoutRowButtons.Location = new Point(2, 658);
            tableLayoutRowButtons.Margin = new Padding(2);
            tableLayoutRowButtons.Name = "tableLayoutRowButtons";
            tableLayoutRowButtons.RowCount = 1;
            tableLayoutRowButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.Size = new Size(552, 61);
            tableLayoutRowButtons.TabIndex = 34;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Location = new Point(127, 6);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(51, 48);
            btnReload.TabIndex = 36;
            btnReload.Text = "↻";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReloadFolder_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(2, 6);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 48);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRem
            // 
            btnRem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRem.Enabled = false;
            btnRem.Location = new Point(182, 6);
            btnRem.Margin = new Padding(2);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(51, 48);
            btnRem.TabIndex = 35;
            btnRem.Text = "-";
            btnRem.UseVisualStyleBackColor = true;
            btnRem.Click += btnClear_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(434, 6);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 48);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(4, 571);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 36;
            lblStatus.Text = "Status:";
            // 
            // tableLayoutAddOptions
            // 
            tableLayoutAddOptions.ColumnCount = 3;
            tableLayoutAddOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 223F));
            tableLayoutAddOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutAddOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAddOptions.Controls.Add(chkAddFolders, 0, 0);
            tableLayoutAddOptions.Controls.Add(chkParseSubfolders, 1, 0);
            tableLayoutAddOptions.Dock = DockStyle.Fill;
            tableLayoutAddOptions.Location = new Point(3, 519);
            tableLayoutAddOptions.Name = "tableLayoutAddOptions";
            tableLayoutAddOptions.RowCount = 1;
            tableLayoutAddOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutAddOptions.Size = new Size(550, 39);
            tableLayoutAddOptions.TabIndex = 37;
            // 
            // chkAddFolders
            // 
            chkAddFolders.Anchor = AnchorStyles.Left;
            chkAddFolders.AutoSize = true;
            chkAddFolders.Location = new Point(3, 5);
            chkAddFolders.Name = "chkAddFolders";
            chkAddFolders.Size = new Size(209, 29);
            chkAddFolders.TabIndex = 0;
            chkAddFolders.Text = "Allow Adding Folders";
            chkAddFolders.UseVisualStyleBackColor = true;
            chkAddFolders.CheckedChanged += chkAddFolders_CheckedChanged;
            // 
            // chkParseSubfolders
            // 
            chkParseSubfolders.Anchor = AnchorStyles.Left;
            chkParseSubfolders.AutoSize = true;
            chkParseSubfolders.Location = new Point(226, 5);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(170, 29);
            chkParseSubfolders.TabIndex = 1;
            chkParseSubfolders.Text = "Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            chkParseSubfolders.CheckedChanged += chkParseSubfolders_CheckedChanged;
            // 
            // FilesListControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutFiles);
            Margin = new Padding(2);
            Name = "FilesListControl";
            Size = new Size(556, 721);
            tableLayoutFiles.ResumeLayout(false);
            tableLayoutFiles.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutRowButtons.ResumeLayout(false);
            tableLayoutAddOptions.ResumeLayout(false);
            tableLayoutAddOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutFiles;
        private Label lblAddFiles;
        private ListBox lstFiles;
        private TableLayoutPanel tableLayoutRowButtons;
        private Button btnClear;
        private Button btnRem;
        private Button btnAdd;
        private Button btnReload;
        private FolderBrowserDialog mFolderBrowserDialog;
        private ProgressBar progressBar;
        private Label lblStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSelectDesel;
        private TableLayoutPanel tableLayoutAddOptions;
        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
    }
}

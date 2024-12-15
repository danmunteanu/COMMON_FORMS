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
            btnSettings = new Button();
            btnReload = new Button();
            btnAdd = new Button();
            btnRem = new Button();
            btnClear = new Button();
            lblStatus = new Label();
            mFolderBrowserDialog = new FolderBrowserDialog();
            tableLayoutFiles.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutRowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutFiles
            // 
            tableLayoutFiles.ColumnCount = 1;
            tableLayoutFiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFiles.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutFiles.Controls.Add(progressBar, 0, 3);
            tableLayoutFiles.Controls.Add(lstFiles, 0, 1);
            tableLayoutFiles.Controls.Add(tableLayoutRowButtons, 0, 4);
            tableLayoutFiles.Controls.Add(lblStatus, 0, 2);
            tableLayoutFiles.Dock = DockStyle.Fill;
            tableLayoutFiles.Location = new Point(0, 0);
            tableLayoutFiles.Name = "tableLayoutFiles";
            tableLayoutFiles.RowCount = 5;
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutFiles.Size = new Size(445, 577);
            tableLayoutFiles.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSelectDesel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 3);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(441, 29);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // lblAddFiles
            // 
            lblAddFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAddFiles.AutoSize = true;
            lblAddFiles.Location = new Point(3, 9);
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.Size = new Size(216, 20);
            lblAddFiles.TabIndex = 26;
            lblAddFiles.Text = "↓↓ Add Files To Merge ↓↓";
            // 
            // btnSelectDesel
            // 
            btnSelectDesel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDesel.Font = new Font("Segoe UI", 7F);
            btnSelectDesel.Location = new Point(361, 3);
            btnSelectDesel.Margin = new Padding(2, 3, 2, 3);
            btnSelectDesel.Name = "btnSelectDesel";
            btnSelectDesel.Size = new Size(78, 23);
            btnSelectDesel.TabIndex = 27;
            btnSelectDesel.Text = "SELECT ALL";
            btnSelectDesel.UseVisualStyleBackColor = true;
            btnSelectDesel.Click += btnSelectDesel_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(3, 486);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(439, 32);
            progressBar.TabIndex = 35;
            // 
            // lstFiles
            // 
            lstFiles.AllowDrop = true;
            lstFiles.Dock = DockStyle.Fill;
            lstFiles.FormattingEnabled = true;
            lstFiles.Location = new Point(2, 38);
            lstFiles.Margin = new Padding(2, 3, 2, 3);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(441, 405);
            lstFiles.TabIndex = 18;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.DragEnter += listFiles_DragEnter;
            // 
            // tableLayoutRowButtons
            // 
            tableLayoutRowButtons.ColumnCount = 6;
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tableLayoutRowButtons.Controls.Add(btnSettings, 5, 0);
            tableLayoutRowButtons.Controls.Add(btnReload, 1, 0);
            tableLayoutRowButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutRowButtons.Controls.Add(btnRem, 2, 0);
            tableLayoutRowButtons.Controls.Add(btnClear, 4, 0);
            tableLayoutRowButtons.Dock = DockStyle.Fill;
            tableLayoutRowButtons.Location = new Point(2, 525);
            tableLayoutRowButtons.Margin = new Padding(2, 3, 2, 3);
            tableLayoutRowButtons.Name = "tableLayoutRowButtons";
            tableLayoutRowButtons.RowCount = 1;
            tableLayoutRowButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.Size = new Size(441, 49);
            tableLayoutRowButtons.TabIndex = 34;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.Font = new Font("Segoe UI", 7F);
            btnSettings.Location = new Point(372, 8);
            btnSettings.Margin = new Padding(2, 3, 2, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(67, 33);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "SETTINGS";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.None;
            btnReload.Location = new Point(97, 9);
            btnReload.Margin = new Padding(2, 3, 2, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(30, 30);
            btnReload.TabIndex = 36;
            btnReload.Text = "↻";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReloadFolder_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Font = new Font("Segoe UI", 7F);
            btnAdd.Location = new Point(2, 8);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 33);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRem
            // 
            btnRem.Anchor = AnchorStyles.None;
            btnRem.Enabled = false;
            btnRem.Location = new Point(131, 9);
            btnRem.Margin = new Padding(2, 3, 2, 3);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(30, 30);
            btnRem.TabIndex = 35;
            btnRem.Text = "-";
            btnRem.UseVisualStyleBackColor = true;
            btnRem.Click += btnClear_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 7F);
            btnClear.Location = new Point(309, 8);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 33);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 454);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 36;
            lblStatus.Text = "Status:";
            // 
            // FilesListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutFiles);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FilesListControl";
            Size = new Size(445, 577);
            tableLayoutFiles.ResumeLayout(false);
            tableLayoutFiles.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutRowButtons.ResumeLayout(false);
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
        private Button btnSettings;
    }
}

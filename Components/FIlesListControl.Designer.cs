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
            btnSettings = new Button();
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
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutFiles.Size = new Size(445, 577);
            tableLayoutFiles.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.Controls.Add(btnSettings, 3, 0);
            tableLayoutPanel1.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSelectDesel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(441, 28);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.Font = new Font("Segoe UI", 7F);
            btnSettings.Location = new Point(338, 2);
            btnSettings.Margin = new Padding(2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(101, 24);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "LIST SETTINGS";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblAddFiles
            // 
            lblAddFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAddFiles.AutoSize = true;
            lblAddFiles.Location = new Point(3, 0);
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.Size = new Size(169, 28);
            lblAddFiles.TabIndex = 26;
            lblAddFiles.Text = "↓↓ Add Files To Merge ↓↓";
            // 
            // btnSelectDesel
            // 
            btnSelectDesel.Dock = DockStyle.Fill;
            btnSelectDesel.Font = new Font("Segoe UI", 7F);
            btnSelectDesel.Location = new Point(253, 2);
            btnSelectDesel.Margin = new Padding(2);
            btnSelectDesel.Name = "btnSelectDesel";
            btnSelectDesel.Size = new Size(81, 24);
            btnSelectDesel.TabIndex = 27;
            btnSelectDesel.Text = "SELECT ALL";
            btnSelectDesel.UseVisualStyleBackColor = true;
            btnSelectDesel.Click += btnSelectDesel_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(3, 491);
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
            lstFiles.Location = new Point(2, 35);
            lstFiles.Margin = new Padding(2, 3, 2, 3);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(441, 413);
            lstFiles.TabIndex = 18;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.DragEnter += listFiles_DragEnter;
            // 
            // tableLayoutRowButtons
            // 
            tableLayoutRowButtons.ColumnCount = 5;
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutRowButtons.Controls.Add(btnReload, 1, 0);
            tableLayoutRowButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutRowButtons.Controls.Add(btnRem, 2, 0);
            tableLayoutRowButtons.Controls.Add(btnClear, 4, 0);
            tableLayoutRowButtons.Dock = DockStyle.Fill;
            tableLayoutRowButtons.Location = new Point(2, 529);
            tableLayoutRowButtons.Margin = new Padding(2);
            tableLayoutRowButtons.Name = "tableLayoutRowButtons";
            tableLayoutRowButtons.RowCount = 1;
            tableLayoutRowButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.Size = new Size(441, 46);
            tableLayoutRowButtons.TabIndex = 34;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Location = new Point(102, 4);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(40, 38);
            btnReload.TabIndex = 36;
            btnReload.Text = "↻";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReloadFolder_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(2, 4);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 38);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRem
            // 
            btnRem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRem.Enabled = false;
            btnRem.Location = new Point(146, 4);
            btnRem.Margin = new Padding(2);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(40, 38);
            btnRem.TabIndex = 35;
            btnRem.Text = "-";
            btnRem.UseVisualStyleBackColor = true;
            btnRem.Click += btnClear_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(347, 4);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 38);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 459);
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
            Margin = new Padding(2);
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

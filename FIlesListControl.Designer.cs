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
            progressBar = new ProgressBar();
            lblAddFiles = new Label();
            lstFiles = new ListBox();
            tableLayoutRowButtons = new TableLayoutPanel();
            btnReload = new Button();
            btnAdd = new Button();
            btnRem = new Button();
            btnClear = new Button();
            lblStatus = new Label();
            mFolderBrowserDialog = new FolderBrowserDialog();
            tableLayoutFiles.SuspendLayout();
            tableLayoutRowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutFiles
            // 
            tableLayoutFiles.ColumnCount = 1;
            tableLayoutFiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFiles.Controls.Add(progressBar, 0, 3);
            tableLayoutFiles.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutFiles.Controls.Add(lstFiles, 0, 1);
            tableLayoutFiles.Controls.Add(tableLayoutRowButtons, 0, 4);
            tableLayoutFiles.Controls.Add(lblStatus, 0, 2);
            tableLayoutFiles.Dock = DockStyle.Fill;
            tableLayoutFiles.Location = new Point(0, 0);
            tableLayoutFiles.Margin = new Padding(4);
            tableLayoutFiles.Name = "tableLayoutFiles";
            tableLayoutFiles.RowCount = 5;
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutFiles.Size = new Size(569, 710);
            tableLayoutFiles.TabIndex = 33;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(4, 600);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(561, 40);
            progressBar.TabIndex = 35;
            // 
            // lblAddFiles
            // 
            lblAddFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddFiles.AutoSize = true;
            lblAddFiles.Location = new Point(4, 15);
            lblAddFiles.Margin = new Padding(4, 0, 4, 0);
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.Size = new Size(210, 25);
            lblAddFiles.TabIndex = 26;
            lblAddFiles.Text = "↓↓ Add Files To Merge ↓↓";
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
            lstFiles.Size = new Size(565, 503);
            lstFiles.TabIndex = 18;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.DragEnter += listFiles_DragEnter;
            // 
            // tableLayoutRowButtons
            // 
            tableLayoutRowButtons.ColumnCount = 5;
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutRowButtons.Controls.Add(btnReload, 1, 0);
            tableLayoutRowButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutRowButtons.Controls.Add(btnRem, 2, 0);
            tableLayoutRowButtons.Controls.Add(btnClear, 4, 0);
            tableLayoutRowButtons.Dock = DockStyle.Fill;
            tableLayoutRowButtons.Location = new Point(2, 647);
            tableLayoutRowButtons.Margin = new Padding(2);
            tableLayoutRowButtons.Name = "tableLayoutRowButtons";
            tableLayoutRowButtons.RowCount = 1;
            tableLayoutRowButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.Size = new Size(565, 61);
            tableLayoutRowButtons.TabIndex = 34;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Location = new Point(152, 6);
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
            btnAdd.Size = new Size(146, 48);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRem
            // 
            btnRem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRem.Enabled = false;
            btnRem.Location = new Point(207, 6);
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
            btnClear.Location = new Point(447, 6);
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
            lblStatus.Location = new Point(4, 560);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 36;
            lblStatus.Text = "Status:";
            // 
            // FilesListControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutFiles);
            Margin = new Padding(2);
            Name = "FilesListControl";
            Size = new Size(569, 710);
            tableLayoutFiles.ResumeLayout(false);
            tableLayoutFiles.PerformLayout();
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
    }
}

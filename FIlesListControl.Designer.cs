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
            progressBarAdd = new ProgressBar();
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
            tableLayoutFiles.Controls.Add(progressBarAdd, 0, 3);
            tableLayoutFiles.Controls.Add(lblAddFiles, 0, 0);
            tableLayoutFiles.Controls.Add(lstFiles, 0, 1);
            tableLayoutFiles.Controls.Add(tableLayoutRowButtons, 0, 4);
            tableLayoutFiles.Controls.Add(lblStatus, 0, 2);
            tableLayoutFiles.Dock = DockStyle.Fill;
            tableLayoutFiles.Location = new Point(0, 0);
            tableLayoutFiles.Name = "tableLayoutFiles";
            tableLayoutFiles.RowCount = 5;
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutFiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutFiles.Size = new Size(455, 568);
            tableLayoutFiles.TabIndex = 33;
            // 
            // progressBarAdd
            // 
            progressBarAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            progressBarAdd.Location = new Point(3, 480);
            progressBarAdd.Margin = new Padding(3, 4, 3, 4);
            progressBarAdd.Name = "progressBarAdd";
            progressBarAdd.Size = new Size(449, 32);
            progressBarAdd.TabIndex = 35;
            // 
            // lblAddFiles
            // 
            lblAddFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddFiles.AutoSize = true;
            lblAddFiles.Location = new Point(3, 12);
            lblAddFiles.Name = "lblAddFiles";
            lblAddFiles.Size = new Size(173, 20);
            lblAddFiles.TabIndex = 26;
            lblAddFiles.Text = "↓↓ Add Files To Merge ↓↓";
            // 
            // lstFiles
            // 
            lstFiles.AllowDrop = true;
            lstFiles.Dock = DockStyle.Fill;
            lstFiles.FormattingEnabled = true;
            lstFiles.Location = new Point(2, 35);
            lstFiles.Margin = new Padding(2, 3, 2, 3);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(451, 403);
            lstFiles.TabIndex = 18;
            lstFiles.SelectedIndexChanged += lstFiles_SelectedIndexChanged;
            lstFiles.DragDrop += listFiles_DragDrop;
            lstFiles.DragEnter += listFiles_DragEnter;
            // 
            // tableLayoutRowButtons
            // 
            tableLayoutRowButtons.ColumnCount = 5;
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutRowButtons.Controls.Add(btnReload, 1, 0);
            tableLayoutRowButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutRowButtons.Controls.Add(btnRem, 2, 0);
            tableLayoutRowButtons.Controls.Add(btnClear, 4, 0);
            tableLayoutRowButtons.Dock = DockStyle.Fill;
            tableLayoutRowButtons.Location = new Point(2, 518);
            tableLayoutRowButtons.Margin = new Padding(2);
            tableLayoutRowButtons.Name = "tableLayoutRowButtons";
            tableLayoutRowButtons.RowCount = 1;
            tableLayoutRowButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRowButtons.Size = new Size(451, 48);
            tableLayoutRowButtons.TabIndex = 34;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Location = new Point(98, 5);
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
            btnAdd.Location = new Point(2, 5);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 38);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRem
            // 
            btnRem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRem.Enabled = false;
            btnRem.Location = new Point(142, 5);
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
            btnClear.Location = new Point(357, 5);
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
            lblStatus.Location = new Point(3, 448);
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
            Size = new Size(455, 568);
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
        private ProgressBar progressBarAdd;
        private Label lblStatus;
    }
}

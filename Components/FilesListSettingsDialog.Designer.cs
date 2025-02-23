namespace CommonForms.Components
{
    partial class FilesListSettingsDialog
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
            chkAddFolders = new CheckBox();
            chkParseSubfolders = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            chkShowStatus = new CheckBox();
            chkShowProgressBar = new CheckBox();
            tableLayoutPanelButtons = new TableLayoutPanel();
            tableLayoutPanelLeft = new TableLayoutPanel();
            tableLayoutColumns = new TableLayoutPanel();
            compListExt = new ExtensionsList();
            tableLayoutMaster = new TableLayoutPanel();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            tableLayoutColumns.SuspendLayout();
            tableLayoutMaster.SuspendLayout();
            SuspendLayout();
            // 
            // chkAddFolders
            // 
            chkAddFolders.Anchor = AnchorStyles.Left;
            chkAddFolders.AutoSize = true;
            chkAddFolders.Location = new Point(2, 2);
            chkAddFolders.Margin = new Padding(2);
            chkAddFolders.Name = "chkAddFolders";
            chkAddFolders.Size = new Size(171, 24);
            chkAddFolders.TabIndex = 1;
            chkAddFolders.Text = "Allow Adding Folders";
            chkAddFolders.UseVisualStyleBackColor = true;
            chkAddFolders.CheckedChanged += chkAddFolders_CheckedChanged;
            // 
            // chkParseSubfolders
            // 
            chkParseSubfolders.Anchor = AnchorStyles.Left;
            chkParseSubfolders.AutoSize = true;
            chkParseSubfolders.Location = new Point(2, 30);
            chkParseSubfolders.Margin = new Padding(2);
            chkParseSubfolders.Name = "chkParseSubfolders";
            chkParseSubfolders.Size = new Size(140, 24);
            chkParseSubfolders.TabIndex = 2;
            chkParseSubfolders.Text = "Parse Subfolders";
            chkParseSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Segoe UI", 8F);
            btnCancel.Location = new Point(473, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 8F);
            btnSave.Location = new Point(398, 0);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowStatus
            // 
            chkShowStatus.AutoSize = true;
            chkShowStatus.Location = new Point(3, 91);
            chkShowStatus.Name = "chkShowStatus";
            chkShowStatus.Size = new Size(125, 22);
            chkShowStatus.TabIndex = 5;
            chkShowStatus.Text = "Use Status Bar";
            chkShowStatus.UseVisualStyleBackColor = true;
            // 
            // chkShowProgressBar
            // 
            chkShowProgressBar.AutoSize = true;
            chkShowProgressBar.Location = new Point(3, 119);
            chkShowProgressBar.Name = "chkShowProgressBar";
            chkShowProgressBar.Size = new Size(141, 22);
            chkShowProgressBar.TabIndex = 6;
            chkShowProgressBar.Text = "Use Progress Bar";
            chkShowProgressBar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 3;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnSave, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(12, 229);
            tableLayoutPanelButtons.Margin = new Padding(0);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(548, 30);
            tableLayoutPanelButtons.TabIndex = 8;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.ColumnCount = 1;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Controls.Add(chkParseSubfolders, 0, 1);
            tableLayoutPanelLeft.Controls.Add(chkAddFolders, 0, 0);
            tableLayoutPanelLeft.Controls.Add(chkShowProgressBar, 0, 4);
            tableLayoutPanelLeft.Controls.Add(chkShowStatus, 0, 3);
            tableLayoutPanelLeft.Dock = DockStyle.Fill;
            tableLayoutPanelLeft.Location = new Point(2, 2);
            tableLayoutPanelLeft.Margin = new Padding(2);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 6;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Size = new Size(175, 185);
            tableLayoutPanelLeft.TabIndex = 17;
            // 
            // tableLayoutColumns
            // 
            tableLayoutColumns.ColumnCount = 3;
            tableLayoutColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179F));
            tableLayoutColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 318F));
            tableLayoutColumns.Controls.Add(tableLayoutPanelLeft, 0, 0);
            tableLayoutColumns.Controls.Add(compListExt, 2, 0);
            tableLayoutColumns.Dock = DockStyle.Fill;
            tableLayoutColumns.Location = new Point(14, 22);
            tableLayoutColumns.Margin = new Padding(2);
            tableLayoutColumns.Name = "tableLayoutColumns";
            tableLayoutColumns.RowCount = 1;
            tableLayoutColumns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutColumns.RowStyles.Add(new RowStyle(SizeType.Absolute, 171F));
            tableLayoutColumns.Size = new Size(544, 189);
            tableLayoutColumns.TabIndex = 21;
            // 
            // compListExt
            // 
            compListExt.Dock = DockStyle.Fill;
            compListExt.Location = new Point(229, 3);
            compListExt.Name = "compListExt";
            compListExt.Size = new Size(312, 183);
            compListExt.TabIndex = 18;
            // 
            // tableLayoutMaster
            // 
            tableLayoutMaster.ColumnCount = 3;
            tableLayoutMaster.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutMaster.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMaster.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutMaster.Controls.Add(tableLayoutPanelButtons, 1, 3);
            tableLayoutMaster.Controls.Add(tableLayoutColumns, 1, 1);
            tableLayoutMaster.Dock = DockStyle.Fill;
            tableLayoutMaster.Location = new Point(0, 0);
            tableLayoutMaster.Margin = new Padding(2);
            tableLayoutMaster.Name = "tableLayoutMaster";
            tableLayoutMaster.RowCount = 5;
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutMaster.Size = new Size(572, 271);
            tableLayoutMaster.TabIndex = 22;
            // 
            // FilesListSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 271);
            Controls.Add(tableLayoutMaster);
            Margin = new Padding(2);
            Name = "FilesListSettingsDialog";
            Text = "FilesList Settings";
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelLeft.ResumeLayout(false);
            tableLayoutPanelLeft.PerformLayout();
            tableLayoutColumns.ResumeLayout(false);
            tableLayoutMaster.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chkAddFolders;
        private CheckBox chkParseSubfolders;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkShowStatus;
        private CheckBox chkShowProgressBar;
        private TableLayoutPanel tableLayoutPanelButtons;
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutColumns;
        private TableLayoutPanel tableLayoutMaster;
        private ExtensionsList compListExt;
    }
}

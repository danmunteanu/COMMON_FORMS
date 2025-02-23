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
            lblFileFilters = new Label();
            tableLayoutPanelLeft = new TableLayoutPanel();
            tableLayoutColumns = new TableLayoutPanel();
            tableLayoutPanelButtonsAndFilters = new TableLayoutPanel();
            tableLayoutFilters = new TableLayoutPanel();
            txtFileFilters = new TextBox();
            tableLayoutExtButtons = new TableLayoutPanel();
            btnClearExt = new Button();
            tableLayoutPanelButtonList = new TableLayoutPanel();
            btnAudio = new Button();
            btnTextExt = new Button();
            btnDocExt = new Button();
            btnImages = new Button();
            btnArchives = new Button();
            tableLayoutMaster = new TableLayoutPanel();
            tableLayoutPanelButtons.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            tableLayoutColumns.SuspendLayout();
            tableLayoutPanelButtonsAndFilters.SuspendLayout();
            tableLayoutFilters.SuspendLayout();
            tableLayoutExtButtons.SuspendLayout();
            tableLayoutPanelButtonList.SuspendLayout();
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
            btnCancel.Location = new Point(397, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 28);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 8F);
            btnSave.Location = new Point(332, 0);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 28);
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
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnSave, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(12, 212);
            tableLayoutPanelButtons.Margin = new Padding(0);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(472, 28);
            tableLayoutPanelButtons.TabIndex = 8;
            // 
            // lblFileFilters
            // 
            lblFileFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFileFilters.AutoSize = true;
            lblFileFilters.Location = new Point(3, 4);
            lblFileFilters.Name = "lblFileFilters";
            lblFileFilters.Size = new Size(78, 20);
            lblFileFilters.TabIndex = 15;
            lblFileFilters.Text = "File Filters:";
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
            tableLayoutPanelLeft.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 6;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Size = new Size(175, 168);
            tableLayoutPanelLeft.TabIndex = 17;
            // 
            // tableLayoutColumns
            // 
            tableLayoutColumns.ColumnCount = 3;
            tableLayoutColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179F));
            tableLayoutColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 279F));
            tableLayoutColumns.Controls.Add(tableLayoutPanelButtonsAndFilters, 2, 0);
            tableLayoutColumns.Controls.Add(tableLayoutPanelLeft, 0, 0);
            tableLayoutColumns.Dock = DockStyle.Fill;
            tableLayoutColumns.Location = new Point(14, 22);
            tableLayoutColumns.Margin = new Padding(2, 2, 2, 2);
            tableLayoutColumns.Name = "tableLayoutColumns";
            tableLayoutColumns.RowCount = 1;
            tableLayoutColumns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutColumns.RowStyles.Add(new RowStyle(SizeType.Absolute, 171F));
            tableLayoutColumns.Size = new Size(468, 172);
            tableLayoutColumns.TabIndex = 21;
            // 
            // tableLayoutPanelButtonsAndFilters
            // 
            tableLayoutPanelButtonsAndFilters.AutoSize = true;
            tableLayoutPanelButtonsAndFilters.ColumnCount = 2;
            tableLayoutPanelButtonsAndFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanelButtonsAndFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndFilters.Controls.Add(tableLayoutFilters, 1, 0);
            tableLayoutPanelButtonsAndFilters.Controls.Add(tableLayoutPanelButtonList, 0, 0);
            tableLayoutPanelButtonsAndFilters.Dock = DockStyle.Fill;
            tableLayoutPanelButtonsAndFilters.Location = new Point(191, 2);
            tableLayoutPanelButtonsAndFilters.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelButtonsAndFilters.Name = "tableLayoutPanelButtonsAndFilters";
            tableLayoutPanelButtonsAndFilters.RowCount = 1;
            tableLayoutPanelButtonsAndFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndFilters.Size = new Size(275, 168);
            tableLayoutPanelButtonsAndFilters.TabIndex = 22;
            // 
            // tableLayoutFilters
            // 
            tableLayoutFilters.ColumnCount = 1;
            tableLayoutFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFilters.Controls.Add(lblFileFilters, 0, 0);
            tableLayoutFilters.Controls.Add(txtFileFilters, 0, 1);
            tableLayoutFilters.Controls.Add(tableLayoutExtButtons, 0, 2);
            tableLayoutFilters.Dock = DockStyle.Fill;
            tableLayoutFilters.Location = new Point(82, 2);
            tableLayoutFilters.Margin = new Padding(2, 2, 2, 2);
            tableLayoutFilters.Name = "tableLayoutFilters";
            tableLayoutFilters.RowCount = 3;
            tableLayoutFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutFilters.Size = new Size(191, 164);
            tableLayoutFilters.TabIndex = 18;
            // 
            // txtFileFilters
            // 
            txtFileFilters.Dock = DockStyle.Fill;
            txtFileFilters.Location = new Point(2, 26);
            txtFileFilters.Margin = new Padding(2, 2, 2, 2);
            txtFileFilters.Multiline = true;
            txtFileFilters.Name = "txtFileFilters";
            txtFileFilters.ReadOnly = true;
            txtFileFilters.Size = new Size(187, 112);
            txtFileFilters.TabIndex = 10;
            // 
            // tableLayoutExtButtons
            // 
            tableLayoutExtButtons.ColumnCount = 2;
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutExtButtons.Controls.Add(btnClearExt, 1, 0);
            tableLayoutExtButtons.Dock = DockStyle.Fill;
            tableLayoutExtButtons.Location = new Point(0, 140);
            tableLayoutExtButtons.Margin = new Padding(0);
            tableLayoutExtButtons.Name = "tableLayoutExtButtons";
            tableLayoutExtButtons.RowCount = 1;
            tableLayoutExtButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.Size = new Size(191, 24);
            tableLayoutExtButtons.TabIndex = 13;
            // 
            // btnClearExt
            // 
            btnClearExt.Dock = DockStyle.Fill;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(127, 0);
            btnClearExt.Margin = new Padding(0);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(64, 24);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // tableLayoutPanelButtonList
            // 
            tableLayoutPanelButtonList.ColumnCount = 1;
            tableLayoutPanelButtonList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.Controls.Add(btnAudio, 0, 4);
            tableLayoutPanelButtonList.Controls.Add(btnTextExt, 0, 0);
            tableLayoutPanelButtonList.Controls.Add(btnDocExt, 0, 1);
            tableLayoutPanelButtonList.Controls.Add(btnImages, 0, 2);
            tableLayoutPanelButtonList.Controls.Add(btnArchives, 0, 3);
            tableLayoutPanelButtonList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonList.Location = new Point(2, 2);
            tableLayoutPanelButtonList.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelButtonList.Name = "tableLayoutPanelButtonList";
            tableLayoutPanelButtonList.RowCount = 6;
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.Size = new Size(76, 164);
            tableLayoutPanelButtonList.TabIndex = 17;
            // 
            // btnAudio
            // 
            btnAudio.Dock = DockStyle.Fill;
            btnAudio.Font = new Font("Segoe UI", 7F);
            btnAudio.Location = new Point(2, 114);
            btnAudio.Margin = new Padding(2, 2, 2, 2);
            btnAudio.Name = "btnAudio";
            btnAudio.Size = new Size(72, 24);
            btnAudio.TabIndex = 14;
            btnAudio.Text = "AUDIO";
            btnAudio.UseVisualStyleBackColor = true;
            btnAudio.Click += btnAudio_Click;
            // 
            // btnTextExt
            // 
            btnTextExt.Dock = DockStyle.Fill;
            btnTextExt.Font = new Font("Segoe UI", 7F);
            btnTextExt.Location = new Point(2, 2);
            btnTextExt.Margin = new Padding(2, 2, 2, 2);
            btnTextExt.Name = "btnTextExt";
            btnTextExt.Size = new Size(72, 24);
            btnTextExt.TabIndex = 12;
            btnTextExt.Text = "YAML";
            btnTextExt.UseVisualStyleBackColor = true;
            btnTextExt.Click += btnTextExt_Click;
            // 
            // btnDocExt
            // 
            btnDocExt.Dock = DockStyle.Fill;
            btnDocExt.Font = new Font("Segoe UI", 7F);
            btnDocExt.Location = new Point(2, 30);
            btnDocExt.Margin = new Padding(2, 2, 2, 2);
            btnDocExt.Name = "btnDocExt";
            btnDocExt.Size = new Size(72, 24);
            btnDocExt.TabIndex = 11;
            btnDocExt.Text = "DOCS";
            btnDocExt.UseVisualStyleBackColor = true;
            btnDocExt.Click += btnDocExt_Click;
            // 
            // btnImages
            // 
            btnImages.Dock = DockStyle.Fill;
            btnImages.Font = new Font("Segoe UI", 7F);
            btnImages.Location = new Point(2, 58);
            btnImages.Margin = new Padding(2, 2, 2, 2);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(72, 24);
            btnImages.TabIndex = 9;
            btnImages.Text = "IMAGES";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // btnArchives
            // 
            btnArchives.Dock = DockStyle.Fill;
            btnArchives.Font = new Font("Segoe UI", 7F);
            btnArchives.Location = new Point(2, 86);
            btnArchives.Margin = new Padding(2, 2, 2, 2);
            btnArchives.Name = "btnArchives";
            btnArchives.Size = new Size(72, 24);
            btnArchives.TabIndex = 13;
            btnArchives.Text = "ARCHIVES";
            btnArchives.UseVisualStyleBackColor = true;
            btnArchives.Click += btnArchives_Click;
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
            tableLayoutMaster.Margin = new Padding(2, 2, 2, 2);
            tableLayoutMaster.Name = "tableLayoutMaster";
            tableLayoutMaster.RowCount = 5;
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutMaster.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutMaster.Size = new Size(496, 252);
            tableLayoutMaster.TabIndex = 22;
            // 
            // FilesListSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 252);
            Controls.Add(tableLayoutMaster);
            Margin = new Padding(2);
            Name = "FilesListSettingsDialog";
            Text = "FilesList Settings";
            tableLayoutPanelButtons.ResumeLayout(false);
            tableLayoutPanelLeft.ResumeLayout(false);
            tableLayoutPanelLeft.PerformLayout();
            tableLayoutColumns.ResumeLayout(false);
            tableLayoutColumns.PerformLayout();
            tableLayoutPanelButtonsAndFilters.ResumeLayout(false);
            tableLayoutFilters.ResumeLayout(false);
            tableLayoutFilters.PerformLayout();
            tableLayoutExtButtons.ResumeLayout(false);
            tableLayoutPanelButtonList.ResumeLayout(false);
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
        private Label lblFileFilters;
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutColumns;
        private TableLayoutPanel tableLayoutPanelButtonsAndFilters;
        private TableLayoutPanel tableLayoutFilters;
        private TextBox txtFileFilters;
        private TableLayoutPanel tableLayoutExtButtons;
        private Button btnClearExt;
        private TableLayoutPanel tableLayoutPanelButtonList;
        private Button btnTextExt;
        private Button btnDocExt;
        private Button btnImages;
        private Button btnArchives;
        private TableLayoutPanel tableLayoutMaster;
        private Button btnAudio;
    }
}

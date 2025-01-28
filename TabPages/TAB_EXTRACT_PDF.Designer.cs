namespace CommonForms
{
    partial class TAB_EXTRACT_PDF
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
            lblExtractFromDoc = new Label();
            txtSource = new TextBox();
            btnSelectDoc = new Button();
            lblPages = new Label();
            txtPages = new TextBox();
            btnClearPages = new Button();
            lblDocInfo = new Label();
            lblPageCount = new Label();
            btnExtract = new Button();
            tableLayoutDetails = new TableLayoutPanel();
            chkAllowDuplicates = new CheckBox();
            lblStatus = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutDetails.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblExtractFromDoc
            // 
            lblExtractFromDoc.Anchor = AnchorStyles.Right;
            lblExtractFromDoc.AutoSize = true;
            lblExtractFromDoc.Location = new Point(15, 10);
            lblExtractFromDoc.Name = "lblExtractFromDoc";
            lblExtractFromDoc.Size = new Size(145, 20);
            lblExtractFromDoc.TabIndex = 0;
            lblExtractFromDoc.Text = "PDF To Extract From:";
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSource.Location = new Point(166, 6);
            txtSource.Margin = new Padding(3, 2, 3, 2);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(711, 27);
            txtSource.TabIndex = 1;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.AllowDrop = true;
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(883, 4);
            btnSelectDoc.Margin = new Padding(3, 2, 3, 2);
            btnSelectDoc.MinimumSize = new Size(0, 32);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(114, 32);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "Select";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSource_Click;
            btnSelectDoc.DragDrop += btnSelectDoc_DragDrop;
            btnSelectDoc.DragEnter += btnSelectDoc_DragEnter;
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(41, 90);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(119, 20);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(166, 86);
            txtPages.Margin = new Padding(3, 2, 3, 2);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(711, 27);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Font = new Font("Segoe UI", 7F);
            btnClearPages.Location = new Point(883, 87);
            btnClearPages.Margin = new Padding(3, 2, 3, 2);
            btnClearPages.Name = "btnClearPages";
            btnClearPages.Size = new Size(25, 25);
            btnClearPages.TabIndex = 7;
            btnClearPages.Text = "X";
            btnClearPages.UseVisualStyleBackColor = true;
            btnClearPages.Click += btnClearPages_Click;
            // 
            // lblDocInfo
            // 
            lblDocInfo.Anchor = AnchorStyles.Right;
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(49, 50);
            lblDocInfo.Name = "lblDocInfo";
            lblDocInfo.Size = new Size(111, 20);
            lblDocInfo.TabIndex = 19;
            lblDocInfo.Text = "Document Info:";
            // 
            // lblPageCount
            // 
            lblPageCount.Anchor = AnchorStyles.Left;
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPageCount.Location = new Point(166, 50);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(58, 20);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // btnExtract
            // 
            btnExtract.Dock = DockStyle.Fill;
            btnExtract.Location = new Point(1, 663);
            btnExtract.Margin = new Padding(1, 3, 1, 3);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(1005, 42);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "EXTRACT PAGES";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 5;
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutDetails.Controls.Add(chkAllowDuplicates, 2, 3);
            tableLayoutDetails.Controls.Add(lblExtractFromDoc, 1, 0);
            tableLayoutDetails.Controls.Add(txtSource, 2, 0);
            tableLayoutDetails.Controls.Add(btnSelectDoc, 3, 0);
            tableLayoutDetails.Controls.Add(btnClearPages, 3, 2);
            tableLayoutDetails.Controls.Add(txtPages, 2, 2);
            tableLayoutDetails.Controls.Add(lblDocInfo, 1, 1);
            tableLayoutDetails.Controls.Add(lblPages, 1, 2);
            tableLayoutDetails.Controls.Add(lblStatus, 2, 4);
            tableLayoutDetails.Controls.Add(lblPageCount, 2, 1);
            tableLayoutDetails.Dock = DockStyle.Fill;
            tableLayoutDetails.Location = new Point(2, 26);
            tableLayoutDetails.Margin = new Padding(2);
            tableLayoutDetails.Name = "tableLayoutDetails";
            tableLayoutDetails.RowCount = 6;
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDetails.Size = new Size(1003, 236);
            tableLayoutDetails.TabIndex = 22;
            // 
            // chkAllowDuplicates
            // 
            chkAllowDuplicates.Anchor = AnchorStyles.Left;
            chkAllowDuplicates.AutoSize = true;
            chkAllowDuplicates.Checked = true;
            chkAllowDuplicates.CheckState = CheckState.Checked;
            chkAllowDuplicates.Location = new Point(165, 128);
            chkAllowDuplicates.Margin = new Padding(2);
            chkAllowDuplicates.Name = "chkAllowDuplicates";
            chkAllowDuplicates.Size = new Size(179, 24);
            chkAllowDuplicates.TabIndex = 21;
            chkAllowDuplicates.Text = "Allow Page Duplicates";
            chkAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(166, 176);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 20);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(btnExtract, 0, 3);
            tableLayoutMain.Controls.Add(tableLayoutDetails, 0, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutMain.Size = new Size(1007, 708);
            tableLayoutMain.TabIndex = 23;
            // 
            // TAB_EXTRACT_PDF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TAB_EXTRACT_PDF";
            Size = new Size(1007, 708);
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblExtractFromDoc;
        private TextBox txtSource;
        private Button btnSelectDoc;
        private Label lblPages;
        private TextBox txtPages;
        private Button btnClearPages;
        private Label lblPageCount;
        private Label lblDocInfo;
        private Button btnExtract;
        private TableLayoutPanel tableLayoutDetails;
        private Label lblStatus;
        private CheckBox chkAllowDuplicates;
        private TableLayoutPanel tableLayoutMain;
    }
}

namespace CommonForms
{
    partial class TAB_ExtractPDF
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
            tableLayoutPanel1 = new TableLayoutPanel();
            chkAllowDuplicates = new CheckBox();
            lblStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblExtractFromDoc
            // 
            lblExtractFromDoc.Anchor = AnchorStyles.Right;
            lblExtractFromDoc.AutoSize = true;
            lblExtractFromDoc.Location = new Point(61, 62);
            lblExtractFromDoc.Margin = new Padding(4, 0, 4, 0);
            lblExtractFromDoc.Name = "lblExtractFromDoc";
            lblExtractFromDoc.Size = new Size(175, 25);
            lblExtractFromDoc.TabIndex = 0;
            lblExtractFromDoc.Text = "PDF To Extract From:";
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSource.Location = new Point(244, 59);
            txtSource.Margin = new Padding(4, 2, 4, 2);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(658, 31);
            txtSource.TabIndex = 1;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(910, 55);
            btnSelectDoc.Margin = new Padding(4, 2, 4, 2);
            btnSelectDoc.MinimumSize = new Size(0, 40);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(142, 40);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "Select";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSource_Click;
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(94, 162);
            lblPages.Margin = new Padding(4, 0, 4, 0);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(142, 25);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(244, 159);
            txtPages.Margin = new Padding(4, 2, 4, 2);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(658, 31);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Font = new Font("Segoe UI", 7F);
            btnClearPages.Location = new Point(910, 159);
            btnClearPages.Margin = new Padding(4, 2, 4, 2);
            btnClearPages.Name = "btnClearPages";
            btnClearPages.Size = new Size(31, 31);
            btnClearPages.TabIndex = 7;
            btnClearPages.Text = "X";
            btnClearPages.UseVisualStyleBackColor = true;
            btnClearPages.Click += btnClearPages_Click;
            // 
            // lblDocInfo
            // 
            lblDocInfo.Anchor = AnchorStyles.Right;
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(100, 112);
            lblDocInfo.Margin = new Padding(4, 0, 4, 0);
            lblDocInfo.Name = "lblDocInfo";
            lblDocInfo.Size = new Size(136, 25);
            lblDocInfo.TabIndex = 19;
            lblDocInfo.Text = "Document Info:";
            // 
            // lblPageCount
            // 
            lblPageCount.Anchor = AnchorStyles.Left;
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPageCount.Location = new Point(244, 112);
            lblPageCount.Margin = new Padding(4, 0, 4, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(73, 25);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // btnExtract
            // 
            btnExtract.Dock = DockStyle.Fill;
            btnExtract.Location = new Point(244, 302);
            btnExtract.Margin = new Padding(4, 2, 4, 2);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(658, 66);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "EXTRACT PAGES";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(chkAllowDuplicates, 2, 4);
            tableLayoutPanel1.Controls.Add(lblExtractFromDoc, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSource, 2, 1);
            tableLayoutPanel1.Controls.Add(btnSelectDoc, 3, 1);
            tableLayoutPanel1.Controls.Add(btnExtract, 2, 6);
            tableLayoutPanel1.Controls.Add(btnClearPages, 3, 3);
            tableLayoutPanel1.Controls.Add(txtPages, 2, 3);
            tableLayoutPanel1.Controls.Add(lblDocInfo, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPages, 1, 3);
            tableLayoutPanel1.Controls.Add(lblStatus, 2, 5);
            tableLayoutPanel1.Controls.Add(lblPageCount, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1096, 526);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // chkAllowDuplicates
            // 
            chkAllowDuplicates.Anchor = AnchorStyles.Left;
            chkAllowDuplicates.AutoSize = true;
            chkAllowDuplicates.Checked = true;
            chkAllowDuplicates.CheckState = CheckState.Checked;
            chkAllowDuplicates.Location = new Point(242, 210);
            chkAllowDuplicates.Margin = new Padding(2);
            chkAllowDuplicates.Name = "chkAllowDuplicates";
            chkAllowDuplicates.Size = new Size(212, 29);
            chkAllowDuplicates.TabIndex = 21;
            chkAllowDuplicates.Text = "Allow Page Duplicates";
            chkAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(244, 262);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // TAB_ExtractPDF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "TAB_ExtractPDF";
            Size = new Size(1096, 526);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblStatus;
        private CheckBox chkAllowDuplicates;
    }
}

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
            lblSaveExportAs = new Label();
            lblPages = new Label();
            txtPages = new TextBox();
            btnClearPages = new Button();
            txtDest = new TextBox();
            btnSelectOutput = new Button();
            lblStatus = new Label();
            lblDocInfo = new Label();
            lblPageCount = new Label();
            btnExtract = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblExtractFromDoc
            // 
            lblExtractFromDoc.Anchor = AnchorStyles.Right;
            lblExtractFromDoc.AutoSize = true;
            lblExtractFromDoc.Location = new Point(71, 62);
            lblExtractFromDoc.Margin = new Padding(4, 0, 4, 0);
            lblExtractFromDoc.Name = "lblExtractFromDoc";
            lblExtractFromDoc.Size = new Size(175, 25);
            lblExtractFromDoc.TabIndex = 0;
            lblExtractFromDoc.Text = "PDF To Extract From:";
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSource.Location = new Point(254, 59);
            txtSource.Margin = new Padding(4, 3, 4, 3);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(580, 31);
            txtSource.TabIndex = 1;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(842, 55);
            btnSelectDoc.Margin = new Padding(4, 3, 4, 3);
            btnSelectDoc.MinimumSize = new Size(0, 40);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(142, 40);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "Select";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSource_Click;
            // 
            // lblSaveExportAs
            // 
            lblSaveExportAs.Anchor = AnchorStyles.Right;
            lblSaveExportAs.AutoSize = true;
            lblSaveExportAs.Location = new Point(43, 212);
            lblSaveExportAs.Margin = new Padding(4, 0, 4, 0);
            lblSaveExportAs.Name = "lblSaveExportAs";
            lblSaveExportAs.Size = new Size(203, 25);
            lblSaveExportAs.TabIndex = 4;
            lblSaveExportAs.Text = "Save Exported Pages To:";
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(104, 162);
            lblPages.Margin = new Padding(4, 0, 4, 0);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(142, 25);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(254, 159);
            txtPages.Margin = new Padding(4, 3, 4, 3);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(580, 31);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Location = new Point(842, 155);
            btnClearPages.Margin = new Padding(4, 3, 4, 3);
            btnClearPages.Name = "btnClearPages";
            btnClearPages.Size = new Size(40, 40);
            btnClearPages.TabIndex = 7;
            btnClearPages.Text = "X";
            btnClearPages.UseVisualStyleBackColor = true;
            btnClearPages.Click += btnClearPages_Click;
            // 
            // txtDest
            // 
            txtDest.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDest.Location = new Point(254, 209);
            txtDest.Margin = new Padding(4, 3, 4, 3);
            txtDest.Name = "txtDest";
            txtDest.ReadOnly = true;
            txtDest.Size = new Size(580, 31);
            txtDest.TabIndex = 8;
            // 
            // btnSelectOutput
            // 
            btnSelectOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectOutput.Location = new Point(842, 205);
            btnSelectOutput.Margin = new Padding(4, 3, 4, 3);
            btnSelectOutput.MinimumSize = new Size(0, 40);
            btnSelectOutput.Name = "btnSelectOutput";
            btnSelectOutput.Size = new Size(142, 40);
            btnSelectOutput.TabIndex = 9;
            btnSelectOutput.Text = "Select";
            btnSelectOutput.UseVisualStyleBackColor = true;
            btnSelectOutput.Click += btnDest_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(254, 285);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 21;
            lblStatus.Text = "Status:";
            // 
            // lblDocInfo
            // 
            lblDocInfo.Anchor = AnchorStyles.Right;
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(110, 112);
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
            lblPageCount.Location = new Point(254, 112);
            lblPageCount.Margin = new Padding(4, 0, 4, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(73, 25);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // btnExtract
            // 
            btnExtract.Dock = DockStyle.Fill;
            btnExtract.Location = new Point(254, 313);
            btnExtract.Margin = new Padding(4, 3, 4, 3);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(580, 64);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "EXTRACT PAGES";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(lblExtractFromDoc, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSource, 2, 1);
            tableLayoutPanel1.Controls.Add(btnSelectOutput, 3, 4);
            tableLayoutPanel1.Controls.Add(txtDest, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSelectDoc, 3, 1);
            tableLayoutPanel1.Controls.Add(lblSaveExportAs, 1, 4);
            tableLayoutPanel1.Controls.Add(btnExtract, 2, 6);
            tableLayoutPanel1.Controls.Add(lblStatus, 2, 5);
            tableLayoutPanel1.Controls.Add(btnClearPages, 3, 3);
            tableLayoutPanel1.Controls.Add(txtPages, 2, 3);
            tableLayoutPanel1.Controls.Add(lblPageCount, 2, 2);
            tableLayoutPanel1.Controls.Add(lblDocInfo, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPages, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(998, 405);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // TAB_EXTRACT_PDF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TAB_EXTRACT_PDF";
            Size = new Size(998, 405);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblExtractFromDoc;
        private TextBox txtSource;
        private Button btnSelectDoc;
        private Label lblSaveExportAs;
        private Label lblPages;
        private TextBox txtPages;
        private Button btnClearPages;
        private TextBox txtDest;
        private Button btnSelectOutput;
        private Label lblPageCount;
        private Label lblDocInfo;
        private Label lblStatus;
        private Button btnExtract;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

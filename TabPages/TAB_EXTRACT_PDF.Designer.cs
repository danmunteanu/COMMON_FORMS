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
            txtDocument = new TextBox();
            btnSelectDoc = new Button();
            lblPages = new Label();
            txtPages = new TextBox();
            btnClearPages = new Button();
            lblDocInfo = new Label();
            lblPageCount = new Label();
            btnExtract = new Button();
            tableLayoutDetails = new TableLayoutPanel();
            flowLayoutOptions = new FlowLayoutPanel();
            chkAllowDuplicates = new CheckBox();
            chkOnlyOdd = new CheckBox();
            chkOnlyEven = new CheckBox();
            lblStatus = new Label();
            lblOptions = new Label();
            btnReload = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutStuff = new TableLayoutPanel();
            pnlDrag = new Panel();
            tableLayoutDetails.SuspendLayout();
            flowLayoutOptions.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutStuff.SuspendLayout();
            SuspendLayout();
            // 
            // lblExtractFromDoc
            // 
            lblExtractFromDoc.Anchor = AnchorStyles.Right;
            lblExtractFromDoc.AutoSize = true;
            lblExtractFromDoc.Location = new Point(21, 12);
            lblExtractFromDoc.Margin = new Padding(4, 0, 4, 0);
            lblExtractFromDoc.Name = "lblExtractFromDoc";
            lblExtractFromDoc.Size = new Size(175, 25);
            lblExtractFromDoc.TabIndex = 0;
            lblExtractFromDoc.Text = "PDF To Extract From:";
            // 
            // txtDocument
            // 
            txtDocument.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDocument.Location = new Point(204, 9);
            txtDocument.Margin = new Padding(4, 2, 4, 2);
            txtDocument.Name = "txtDocument";
            txtDocument.ReadOnly = true;
            txtDocument.Size = new Size(762, 31);
            txtDocument.TabIndex = 1;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.AllowDrop = true;
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(974, 5);
            btnSelectDoc.Margin = new Padding(4, 2, 4, 2);
            btnSelectDoc.MinimumSize = new Size(0, 40);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(142, 40);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "SELECT";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSelect_Click;
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(54, 107);
            lblPages.Margin = new Padding(4, 0, 4, 0);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(142, 25);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(204, 104);
            txtPages.Margin = new Padding(4, 2, 4, 2);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(762, 31);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Font = new Font("Segoe UI", 7F);
            btnClearPages.Location = new Point(974, 104);
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
            lblDocInfo.Location = new Point(60, 60);
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
            lblPageCount.Location = new Point(204, 60);
            lblPageCount.Margin = new Padding(4, 0, 4, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(73, 25);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // btnExtract
            // 
            btnExtract.Dock = DockStyle.Fill;
            btnExtract.Location = new Point(1, 523);
            btnExtract.Margin = new Padding(1, 4, 1, 4);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(1257, 52);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "EXTRACT PAGES";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 5;
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tableLayoutDetails.Controls.Add(lblExtractFromDoc, 1, 0);
            tableLayoutDetails.Controls.Add(txtDocument, 2, 0);
            tableLayoutDetails.Controls.Add(flowLayoutOptions, 2, 4);
            tableLayoutDetails.Controls.Add(btnSelectDoc, 3, 0);
            tableLayoutDetails.Controls.Add(btnClearPages, 3, 2);
            tableLayoutDetails.Controls.Add(txtPages, 2, 2);
            tableLayoutDetails.Controls.Add(lblDocInfo, 1, 1);
            tableLayoutDetails.Controls.Add(lblPages, 1, 2);
            tableLayoutDetails.Controls.Add(lblStatus, 2, 6);
            tableLayoutDetails.Controls.Add(lblPageCount, 2, 1);
            tableLayoutDetails.Controls.Add(lblOptions, 1, 4);
            tableLayoutDetails.Controls.Add(btnReload, 3, 1);
            tableLayoutDetails.Dock = DockStyle.Fill;
            tableLayoutDetails.Location = new Point(127, 2);
            tableLayoutDetails.Margin = new Padding(2);
            tableLayoutDetails.Name = "tableLayoutDetails";
            tableLayoutDetails.RowCount = 7;
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutDetails.Size = new Size(1124, 310);
            tableLayoutDetails.TabIndex = 22;
            // 
            // flowLayoutOptions
            // 
            flowLayoutOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutOptions.Controls.Add(chkOnlyEven);
            flowLayoutOptions.Controls.Add(chkOnlyOdd);
            flowLayoutOptions.Controls.Add(chkAllowDuplicates);
            flowLayoutOptions.Location = new Point(204, 154);
            flowLayoutOptions.Margin = new Padding(4);
            flowLayoutOptions.Name = "flowLayoutOptions";
            flowLayoutOptions.Size = new Size(218, 112);
            flowLayoutOptions.TabIndex = 23;
            // 
            // chkAllowDuplicates
            // 
            chkAllowDuplicates.Anchor = AnchorStyles.Left;
            chkAllowDuplicates.AutoSize = true;
            chkAllowDuplicates.Checked = true;
            chkAllowDuplicates.CheckState = CheckState.Checked;
            chkAllowDuplicates.Location = new Point(2, 76);
            chkAllowDuplicates.Margin = new Padding(2);
            chkAllowDuplicates.Name = "chkAllowDuplicates";
            chkAllowDuplicates.Size = new Size(212, 29);
            chkAllowDuplicates.TabIndex = 21;
            chkAllowDuplicates.Text = "Allow Page Duplicates";
            chkAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // chkOnlyOdd
            // 
            chkOnlyOdd.AutoSize = true;
            chkOnlyOdd.Location = new Point(4, 41);
            chkOnlyOdd.Margin = new Padding(4);
            chkOnlyOdd.Name = "chkOnlyOdd";
            chkOnlyOdd.Size = new Size(167, 29);
            chkOnlyOdd.TabIndex = 22;
            chkOnlyOdd.Text = "Odd Pages Only";
            chkOnlyOdd.UseVisualStyleBackColor = true;
            chkOnlyOdd.CheckedChanged += chkOnlyOdd_CheckedChanged;
            // 
            // chkOnlyEven
            // 
            chkOnlyEven.AutoSize = true;
            chkOnlyEven.Location = new Point(4, 4);
            chkOnlyEven.Margin = new Padding(4);
            chkOnlyEven.Name = "chkOnlyEven";
            chkOnlyEven.Size = new Size(168, 29);
            chkOnlyEven.TabIndex = 23;
            chkOnlyEven.Text = "Even Pages Only";
            chkOnlyEven.UseVisualStyleBackColor = true;
            chkOnlyEven.CheckedChanged += chkOnlyEven_CheckedChanged;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(204, 285);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // lblOptions
            // 
            lblOptions.Anchor = AnchorStyles.Right;
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(116, 197);
            lblOptions.Margin = new Padding(4, 0, 4, 0);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(80, 25);
            lblOptions.TabIndex = 24;
            lblOptions.Text = "Options:";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            btnReload.Dock = DockStyle.Fill;
            btnReload.Location = new Point(973, 53);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(144, 39);
            btnReload.TabIndex = 25;
            btnReload.Text = "RELOAD";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutStuff, 0, 1);
            tableLayoutMain.Controls.Add(btnExtract, 0, 3);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutMain.Size = new Size(1259, 579);
            tableLayoutMain.TabIndex = 23;
            // 
            // tableLayoutStuff
            // 
            tableLayoutStuff.ColumnCount = 2;
            tableLayoutStuff.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutStuff.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutStuff.Controls.Add(pnlDrag, 0, 0);
            tableLayoutStuff.Controls.Add(tableLayoutDetails, 1, 0);
            tableLayoutStuff.Dock = DockStyle.Fill;
            tableLayoutStuff.Location = new Point(3, 33);
            tableLayoutStuff.Name = "tableLayoutStuff";
            tableLayoutStuff.RowCount = 1;
            tableLayoutStuff.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutStuff.Size = new Size(1253, 314);
            tableLayoutStuff.TabIndex = 24;
            // 
            // pnlDrag
            // 
            pnlDrag.AllowDrop = true;
            pnlDrag.BorderStyle = BorderStyle.FixedSingle;
            pnlDrag.Dock = DockStyle.Fill;
            pnlDrag.Location = new Point(3, 3);
            pnlDrag.Name = "pnlDrag";
            pnlDrag.Size = new Size(119, 308);
            pnlDrag.TabIndex = 25;
            pnlDrag.DragDrop += btnSelectDoc_DragDrop;
            pnlDrag.DragEnter += btnSelectDoc_DragEnter;
            // 
            // TAB_EXTRACT_PDF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(4, 2, 4, 2);
            Name = "TAB_EXTRACT_PDF";
            Size = new Size(1259, 579);
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            flowLayoutOptions.ResumeLayout(false);
            flowLayoutOptions.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutStuff.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblExtractFromDoc;
        private TextBox txtDocument;
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
        private FlowLayoutPanel flowLayoutOptions;
        private CheckBox chkOnlyOdd;
        private CheckBox chkOnlyEven;
        private Label lblOptions;
        private TableLayoutPanel tableLayoutStuff;
        private Panel pnlDrag;
        private Button btnReload;
    }
}

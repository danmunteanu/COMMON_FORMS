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
            btnExtract = new Button();
            tableLayoutStuff = new TableLayoutPanel();
            pnlDrag = new Panel();
            tableLayoutRHS = new TableLayoutPanel();
            tableLayoutDetails = new TableLayoutPanel();
            lblExtractFromDoc = new Label();
            txtDocument = new TextBox();
            tableLayoutOptions = new TableLayoutPanel();
            chkAllowDuplicates = new CheckBox();
            chkOnlyOdd = new CheckBox();
            chkOnlyEven = new CheckBox();
            btnSelectDoc = new Button();
            btnClearPages = new Button();
            txtPages = new TextBox();
            lblDocInfo = new Label();
            lblPages = new Label();
            lblStatus = new Label();
            lblPageCount = new Label();
            lblOptions = new Label();
            btnReload = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutStuff.SuspendLayout();
            tableLayoutRHS.SuspendLayout();
            tableLayoutDetails.SuspendLayout();
            tableLayoutOptions.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnExtract
            // 
            btnExtract.Location = new Point(1, 353);
            btnExtract.Margin = new Padding(1, 3, 1, 3);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(690, 44);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "EXTRACT PAGES";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tableLayoutStuff
            // 
            tableLayoutStuff.ColumnCount = 2;
            tableLayoutStuff.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
            tableLayoutStuff.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutStuff.Controls.Add(pnlDrag, 0, 0);
            tableLayoutStuff.Controls.Add(tableLayoutRHS, 1, 0);
            tableLayoutStuff.Dock = DockStyle.Fill;
            tableLayoutStuff.Location = new Point(2, 26);
            tableLayoutStuff.Margin = new Padding(2);
            tableLayoutStuff.Name = "tableLayoutStuff";
            tableLayoutStuff.RowCount = 1;
            tableLayoutStuff.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutStuff.Size = new Size(1036, 568);
            tableLayoutStuff.TabIndex = 24;
            // 
            // pnlDrag
            // 
            pnlDrag.AllowDrop = true;
            pnlDrag.BorderStyle = BorderStyle.FixedSingle;
            pnlDrag.Location = new Point(0, 0);
            pnlDrag.Margin = new Padding(0);
            pnlDrag.Name = "pnlDrag";
            pnlDrag.Size = new Size(195, 261);
            pnlDrag.TabIndex = 25;
            pnlDrag.DragDrop += btnSelectDoc_DragDrop;
            pnlDrag.DragEnter += btnSelectDoc_DragEnter;
            // 
            // tableLayoutRHS
            // 
            tableLayoutRHS.ColumnCount = 1;
            tableLayoutRHS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRHS.Controls.Add(btnExtract, 0, 1);
            tableLayoutRHS.Controls.Add(tableLayoutDetails, 0, 0);
            tableLayoutRHS.Location = new Point(228, 3);
            tableLayoutRHS.Name = "tableLayoutRHS";
            tableLayoutRHS.RowCount = 2;
            tableLayoutRHS.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRHS.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutRHS.Size = new Size(692, 400);
            tableLayoutRHS.TabIndex = 25;
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 5;
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutDetails.Controls.Add(lblExtractFromDoc, 1, 0);
            tableLayoutDetails.Controls.Add(txtDocument, 2, 0);
            tableLayoutDetails.Controls.Add(tableLayoutOptions, 2, 3);
            tableLayoutDetails.Controls.Add(btnSelectDoc, 3, 0);
            tableLayoutDetails.Controls.Add(btnClearPages, 3, 2);
            tableLayoutDetails.Controls.Add(txtPages, 2, 2);
            tableLayoutDetails.Controls.Add(lblDocInfo, 1, 1);
            tableLayoutDetails.Controls.Add(lblPages, 1, 2);
            tableLayoutDetails.Controls.Add(lblStatus, 2, 4);
            tableLayoutDetails.Controls.Add(lblPageCount, 2, 1);
            tableLayoutDetails.Controls.Add(lblOptions, 1, 3);
            tableLayoutDetails.Controls.Add(btnReload, 3, 1);
            tableLayoutDetails.Dock = DockStyle.Fill;
            tableLayoutDetails.Location = new Point(2, 2);
            tableLayoutDetails.Margin = new Padding(2);
            tableLayoutDetails.Name = "tableLayoutDetails";
            tableLayoutDetails.RowCount = 6;
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDetails.Size = new Size(688, 346);
            tableLayoutDetails.TabIndex = 22;
            // 
            // lblExtractFromDoc
            // 
            lblExtractFromDoc.Anchor = AnchorStyles.Right;
            lblExtractFromDoc.AutoSize = true;
            lblExtractFromDoc.Location = new Point(12, 10);
            lblExtractFromDoc.Name = "lblExtractFromDoc";
            lblExtractFromDoc.Size = new Size(145, 20);
            lblExtractFromDoc.TabIndex = 0;
            lblExtractFromDoc.Text = "PDF To Extract From:";
            // 
            // txtDocument
            // 
            txtDocument.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDocument.Location = new Point(163, 6);
            txtDocument.Margin = new Padding(3, 2, 3, 2);
            txtDocument.Name = "txtDocument";
            txtDocument.ReadOnly = true;
            txtDocument.Size = new Size(422, 27);
            txtDocument.TabIndex = 1;
            // 
            // tableLayoutOptions
            // 
            tableLayoutOptions.ColumnCount = 4;
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutOptions.Controls.Add(chkAllowDuplicates, 2, 0);
            tableLayoutOptions.Controls.Add(chkOnlyOdd, 1, 0);
            tableLayoutOptions.Controls.Add(chkOnlyEven, 0, 0);
            tableLayoutOptions.Dock = DockStyle.Fill;
            tableLayoutOptions.Location = new Point(163, 133);
            tableLayoutOptions.Name = "tableLayoutOptions";
            tableLayoutOptions.RowCount = 1;
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOptions.Size = new Size(422, 34);
            tableLayoutOptions.TabIndex = 25;
            // 
            // chkAllowDuplicates
            // 
            chkAllowDuplicates.Anchor = AnchorStyles.Left;
            chkAllowDuplicates.AutoSize = true;
            chkAllowDuplicates.Checked = true;
            chkAllowDuplicates.CheckState = CheckState.Checked;
            chkAllowDuplicates.Location = new Point(295, 5);
            chkAllowDuplicates.Margin = new Padding(2);
            chkAllowDuplicates.Name = "chkAllowDuplicates";
            chkAllowDuplicates.Size = new Size(179, 24);
            chkAllowDuplicates.TabIndex = 21;
            chkAllowDuplicates.Text = "Allow Page Duplicates";
            chkAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // chkOnlyOdd
            // 
            chkOnlyOdd.Anchor = AnchorStyles.Left;
            chkOnlyOdd.AutoSize = true;
            chkOnlyOdd.Location = new Point(148, 5);
            chkOnlyOdd.Name = "chkOnlyOdd";
            chkOnlyOdd.Size = new Size(136, 24);
            chkOnlyOdd.TabIndex = 22;
            chkOnlyOdd.Text = "Odd Pages Only";
            chkOnlyOdd.UseVisualStyleBackColor = true;
            chkOnlyOdd.CheckedChanged += chkOnlyOdd_CheckedChanged;
            // 
            // chkOnlyEven
            // 
            chkOnlyEven.Anchor = AnchorStyles.Left;
            chkOnlyEven.AutoSize = true;
            chkOnlyEven.Location = new Point(3, 5);
            chkOnlyEven.Name = "chkOnlyEven";
            chkOnlyEven.Size = new Size(138, 24);
            chkOnlyEven.TabIndex = 23;
            chkOnlyEven.Text = "Even Pages Only";
            chkOnlyEven.UseVisualStyleBackColor = true;
            chkOnlyEven.CheckedChanged += chkOnlyEven_CheckedChanged;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.AllowDrop = true;
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(591, 4);
            btnSelectDoc.Margin = new Padding(3, 2, 3, 2);
            btnSelectDoc.MinimumSize = new Size(0, 32);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(91, 32);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "SELECT";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSelect_Click;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Font = new Font("Segoe UI", 7F);
            btnClearPages.Location = new Point(591, 95);
            btnClearPages.Margin = new Padding(3, 2, 3, 2);
            btnClearPages.Name = "btnClearPages";
            btnClearPages.Size = new Size(25, 25);
            btnClearPages.TabIndex = 7;
            btnClearPages.Text = "X";
            btnClearPages.UseVisualStyleBackColor = true;
            btnClearPages.Click += btnClearPages_Click;
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(163, 94);
            txtPages.Margin = new Padding(3, 2, 3, 2);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(422, 27);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // lblDocInfo
            // 
            lblDocInfo.Anchor = AnchorStyles.Right;
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(46, 52);
            lblDocInfo.Name = "lblDocInfo";
            lblDocInfo.Size = new Size(111, 20);
            lblDocInfo.TabIndex = 19;
            lblDocInfo.Text = "Document Info:";
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(38, 97);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(119, 20);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(163, 182);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 20);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // lblPageCount
            // 
            lblPageCount.Anchor = AnchorStyles.Left;
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPageCount.Location = new Point(163, 52);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(58, 20);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // lblOptions
            // 
            lblOptions.Anchor = AnchorStyles.Right;
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(93, 140);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(64, 20);
            lblOptions.TabIndex = 24;
            lblOptions.Text = "Options:";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Top;
            btnReload.Font = new Font("Segoe UI", 7F);
            btnReload.Location = new Point(602, 42);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(68, 26);
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
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 2;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 460F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(1040, 596);
            tableLayoutMain.TabIndex = 23;
            // 
            // TAB_EXTRACT_PDF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TAB_EXTRACT_PDF";
            Size = new Size(1040, 596);
            tableLayoutStuff.ResumeLayout(false);
            tableLayoutRHS.ResumeLayout(false);
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            tableLayoutOptions.ResumeLayout(false);
            tableLayoutOptions.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExtract;
        private TableLayoutPanel tableLayoutStuff;
        private Panel pnlDrag;
        private TableLayoutPanel tableLayoutDetails;
        private Label lblExtractFromDoc;
        private TextBox txtDocument;
        private CheckBox chkOnlyEven;
        private CheckBox chkOnlyOdd;
        private CheckBox chkAllowDuplicates;
        private Button btnSelectDoc;
        private Button btnClearPages;
        private TextBox txtPages;
        private Label lblDocInfo;
        private Label lblPages;
        private Label lblPageCount;
        private Label lblOptions;
        private Button btnReload;
        private TableLayoutPanel tableLayoutMain;
        private Label lblStatus;
        private TableLayoutPanel tableLayoutOptions;
        private TableLayoutPanel tableLayoutRHS;
    }
}

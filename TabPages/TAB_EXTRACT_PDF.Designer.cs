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
            tableLayoutDetails = new TableLayoutPanel();
            lblExtractFromDoc = new Label();
            txtDocument = new TextBox();
            tableLayoutOptions = new TableLayoutPanel();
            chkOnlyEven = new CheckBox();
            chkOnlyOdd = new CheckBox();
            chkAllowDuplicates = new CheckBox();
            btnSelectDoc = new Button();
            btnClearPages = new Button();
            txtPages = new TextBox();
            lblDocInfo = new Label();
            lblPages = new Label();
            lblStatus = new Label();
            lblPageCount = new Label();
            lblOptions = new Label();
            btnReload = new Button();
            lblExclude = new Label();
            txtExclude = new TextBox();
            btnAdvanced = new Button();
            btnClearExclude = new Button();
            tableLayoutDrag = new TableLayoutPanel();
            panelDrag = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutDetails.SuspendLayout();
            tableLayoutOptions.SuspendLayout();
            tableLayoutDrag.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExtract
            // 
            btnExtract.Dock = DockStyle.Bottom;
            btnExtract.Location = new Point(0, 283);
            btnExtract.Margin = new Padding(1, 2, 1, 2);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(825, 39);
            btnExtract.TabIndex = 3;
            btnExtract.Text = "EXTRACT PAGES";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // tableLayoutDetails
            // 
            tableLayoutDetails.ColumnCount = 5;
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tableLayoutDetails.Controls.Add(lblExtractFromDoc, 1, 0);
            tableLayoutDetails.Controls.Add(txtDocument, 2, 0);
            tableLayoutDetails.Controls.Add(tableLayoutOptions, 2, 3);
            tableLayoutDetails.Controls.Add(btnSelectDoc, 3, 0);
            tableLayoutDetails.Controls.Add(btnClearPages, 3, 2);
            tableLayoutDetails.Controls.Add(txtPages, 2, 2);
            tableLayoutDetails.Controls.Add(lblDocInfo, 1, 1);
            tableLayoutDetails.Controls.Add(lblPages, 1, 2);
            tableLayoutDetails.Controls.Add(lblStatus, 2, 5);
            tableLayoutDetails.Controls.Add(lblPageCount, 2, 1);
            tableLayoutDetails.Controls.Add(lblOptions, 1, 3);
            tableLayoutDetails.Controls.Add(btnReload, 3, 1);
            tableLayoutDetails.Controls.Add(lblExclude, 1, 4);
            tableLayoutDetails.Controls.Add(txtExclude, 2, 4);
            tableLayoutDetails.Controls.Add(btnAdvanced, 3, 3);
            tableLayoutDetails.Controls.Add(btnClearExclude, 3, 4);
            tableLayoutDetails.Dock = DockStyle.Fill;
            tableLayoutDetails.Location = new Point(187, 1);
            tableLayoutDetails.Margin = new Padding(1, 1, 1, 1);
            tableLayoutDetails.Name = "tableLayoutDetails";
            tableLayoutDetails.RowCount = 7;
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDetails.Size = new Size(637, 281);
            tableLayoutDetails.TabIndex = 22;
            // 
            // lblExtractFromDoc
            // 
            lblExtractFromDoc.Anchor = AnchorStyles.Right;
            lblExtractFromDoc.AutoSize = true;
            lblExtractFromDoc.Location = new Point(21, 7);
            lblExtractFromDoc.Name = "lblExtractFromDoc";
            lblExtractFromDoc.Size = new Size(116, 15);
            lblExtractFromDoc.TabIndex = 0;
            lblExtractFromDoc.Text = "PDF To Extract From:";
            // 
            // txtDocument
            // 
            txtDocument.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDocument.Location = new Point(143, 3);
            txtDocument.Margin = new Padding(3, 1, 3, 1);
            txtDocument.Name = "txtDocument";
            txtDocument.ReadOnly = true;
            txtDocument.Size = new Size(403, 23);
            txtDocument.TabIndex = 1;
            // 
            // tableLayoutOptions
            // 
            tableLayoutOptions.ColumnCount = 3;
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutOptions.Controls.Add(chkOnlyEven, 0, 1);
            tableLayoutOptions.Controls.Add(chkOnlyOdd, 0, 2);
            tableLayoutOptions.Controls.Add(chkAllowDuplicates, 1, 1);
            tableLayoutOptions.Dock = DockStyle.Fill;
            tableLayoutOptions.Location = new Point(143, 98);
            tableLayoutOptions.Margin = new Padding(3, 2, 3, 2);
            tableLayoutOptions.Name = "tableLayoutOptions";
            tableLayoutOptions.RowCount = 4;
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOptions.Size = new Size(403, 57);
            tableLayoutOptions.TabIndex = 25;
            // 
            // chkOnlyEven
            // 
            chkOnlyEven.Anchor = AnchorStyles.Left;
            chkOnlyEven.AutoSize = true;
            chkOnlyEven.Location = new Point(3, 6);
            chkOnlyEven.Margin = new Padding(3, 2, 3, 2);
            chkOnlyEven.Name = "chkOnlyEven";
            chkOnlyEven.Size = new Size(113, 19);
            chkOnlyEven.TabIndex = 23;
            chkOnlyEven.Text = "Even Pages Only";
            chkOnlyEven.UseVisualStyleBackColor = true;
            chkOnlyEven.CheckedChanged += chkOnlyEven_CheckedChanged;
            // 
            // chkOnlyOdd
            // 
            chkOnlyOdd.Anchor = AnchorStyles.Left;
            chkOnlyOdd.AutoSize = true;
            chkOnlyOdd.Location = new Point(3, 30);
            chkOnlyOdd.Margin = new Padding(3, 2, 3, 2);
            chkOnlyOdd.Name = "chkOnlyOdd";
            chkOnlyOdd.Size = new Size(111, 19);
            chkOnlyOdd.TabIndex = 22;
            chkOnlyOdd.Text = "Odd Pages Only";
            chkOnlyOdd.UseVisualStyleBackColor = true;
            chkOnlyOdd.CheckedChanged += chkOnlyOdd_CheckedChanged;
            // 
            // chkAllowDuplicates
            // 
            chkAllowDuplicates.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkAllowDuplicates.AutoSize = true;
            chkAllowDuplicates.Checked = true;
            chkAllowDuplicates.CheckState = CheckState.Checked;
            chkAllowDuplicates.Location = new Point(128, 6);
            chkAllowDuplicates.Margin = new Padding(1, 1, 1, 1);
            chkAllowDuplicates.Name = "chkAllowDuplicates";
            chkAllowDuplicates.Size = new Size(158, 19);
            chkAllowDuplicates.TabIndex = 21;
            chkAllowDuplicates.Text = "Allow Page Duplicates";
            chkAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.AllowDrop = true;
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(552, 3);
            btnSelectDoc.Margin = new Padding(3, 1, 3, 1);
            btnSelectDoc.MinimumSize = new Size(0, 24);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(79, 24);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "SELECT";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSelect_Click;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Font = new Font("Segoe UI", 7F);
            btnClearPages.Location = new Point(552, 70);
            btnClearPages.Margin = new Padding(3, 1, 3, 1);
            btnClearPages.Name = "btnClearPages";
            btnClearPages.Size = new Size(22, 19);
            btnClearPages.TabIndex = 7;
            btnClearPages.Text = "X";
            btnClearPages.UseVisualStyleBackColor = true;
            btnClearPages.Click += btnClearPages_Click;
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(143, 68);
            txtPages.Margin = new Padding(3, 1, 3, 1);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(403, 23);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // lblDocInfo
            // 
            lblDocInfo.Anchor = AnchorStyles.Right;
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(47, 39);
            lblDocInfo.Name = "lblDocInfo";
            lblDocInfo.Size = new Size(90, 15);
            lblDocInfo.TabIndex = 19;
            lblDocInfo.Text = "Document Info:";
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(42, 72);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(95, 15);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(143, 196);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(40, 15);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // lblPageCount
            // 
            lblPageCount.Anchor = AnchorStyles.Left;
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPageCount.Location = new Point(143, 39);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(48, 15);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // lblOptions
            // 
            lblOptions.Anchor = AnchorStyles.Right;
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(85, 119);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(52, 15);
            lblOptions.TabIndex = 24;
            lblOptions.Text = "Options:";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Font = new Font("Segoe UI", 8F);
            btnReload.Location = new Point(550, 34);
            btnReload.Margin = new Padding(1, 1, 1, 1);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(83, 24);
            btnReload.TabIndex = 25;
            btnReload.Text = "RELOAD";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // lblExclude
            // 
            lblExclude.Anchor = AnchorStyles.Right;
            lblExclude.AutoSize = true;
            lblExclude.Location = new Point(38, 166);
            lblExclude.Margin = new Padding(2, 0, 2, 0);
            lblExclude.Name = "lblExclude";
            lblExclude.Size = new Size(100, 15);
            lblExclude.TabIndex = 27;
            lblExclude.Text = "Pages To Exclude:";
            // 
            // txtExclude
            // 
            txtExclude.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExclude.Location = new Point(142, 162);
            txtExclude.Margin = new Padding(2, 2, 2, 2);
            txtExclude.Name = "txtExclude";
            txtExclude.Size = new Size(405, 23);
            txtExclude.TabIndex = 28;
            txtExclude.KeyPress += txtExclude_KeyPress;
            // 
            // btnAdvanced
            // 
            btnAdvanced.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdvanced.Font = new Font("Segoe UI", 8F);
            btnAdvanced.Location = new Point(551, 114);
            btnAdvanced.Margin = new Padding(2, 2, 2, 2);
            btnAdvanced.Name = "btnAdvanced";
            btnAdvanced.Size = new Size(81, 24);
            btnAdvanced.TabIndex = 26;
            btnAdvanced.Text = "ADVANCED";
            btnAdvanced.UseVisualStyleBackColor = true;
            btnAdvanced.Click += btnAdvanced_Click;
            // 
            // btnClearExclude
            // 
            btnClearExclude.Anchor = AnchorStyles.Left;
            btnClearExclude.Font = new Font("Segoe UI", 7F);
            btnClearExclude.Location = new Point(551, 164);
            btnClearExclude.Margin = new Padding(2, 2, 2, 2);
            btnClearExclude.Name = "btnClearExclude";
            btnClearExclude.Size = new Size(22, 19);
            btnClearExclude.TabIndex = 29;
            btnClearExclude.Text = "X";
            btnClearExclude.UseVisualStyleBackColor = true;
            btnClearExclude.Click += btnClearExclude_Click;
            // 
            // tableLayoutDrag
            // 
            tableLayoutDrag.ColumnCount = 1;
            tableLayoutDrag.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDrag.Controls.Add(panelDrag, 0, 0);
            tableLayoutDrag.Dock = DockStyle.Fill;
            tableLayoutDrag.Location = new Point(2, 2);
            tableLayoutDrag.Margin = new Padding(2, 2, 2, 2);
            tableLayoutDrag.Name = "tableLayoutDrag";
            tableLayoutDrag.RowCount = 2;
            tableLayoutDrag.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutDrag.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDrag.Size = new Size(182, 279);
            tableLayoutDrag.TabIndex = 26;
            // 
            // panelDrag
            // 
            panelDrag.AllowDrop = true;
            panelDrag.BorderStyle = BorderStyle.FixedSingle;
            panelDrag.Dock = DockStyle.Fill;
            panelDrag.Location = new Point(0, 0);
            panelDrag.Margin = new Padding(0);
            panelDrag.Name = "panelDrag";
            panelDrag.Size = new Size(182, 210);
            panelDrag.TabIndex = 25;
            panelDrag.DragDrop += btnSelectDoc_DragDrop;
            panelDrag.DragEnter += btnSelectDoc_DragEnter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutDrag, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutDetails, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(825, 283);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // TAB_EXTRACT_PDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnExtract);
            Margin = new Padding(3, 1, 3, 1);
            Name = "TAB_EXTRACT_PDF";
            Size = new Size(825, 322);
            tableLayoutDetails.ResumeLayout(false);
            tableLayoutDetails.PerformLayout();
            tableLayoutOptions.ResumeLayout(false);
            tableLayoutOptions.PerformLayout();
            tableLayoutDrag.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExtract;
        private Panel panelDrag;
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
        private Label lblStatus;
        private TableLayoutPanel tableLayoutOptions;
        private TableLayoutPanel tableLayoutDrag;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdvanced;
        private Label lblExclude;
        private TextBox txtExclude;
        private Button btnClearExclude;
    }
}

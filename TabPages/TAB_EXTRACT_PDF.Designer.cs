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
            btnExtract.Location = new Point(0, 471);
            btnExtract.Margin = new Padding(1, 4, 1, 4);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(1179, 65);
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
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
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
            tableLayoutDetails.Location = new Point(267, 2);
            tableLayoutDetails.Margin = new Padding(2);
            tableLayoutDetails.Name = "tableLayoutDetails";
            tableLayoutDetails.RowCount = 7;
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDetails.Size = new Size(910, 467);
            tableLayoutDetails.TabIndex = 22;
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
            txtDocument.Size = new Size(577, 31);
            txtDocument.TabIndex = 1;
            // 
            // tableLayoutOptions
            // 
            tableLayoutOptions.ColumnCount = 3;
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableLayoutOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutOptions.Controls.Add(chkOnlyEven, 0, 1);
            tableLayoutOptions.Controls.Add(chkOnlyOdd, 0, 2);
            tableLayoutOptions.Controls.Add(chkAllowDuplicates, 1, 1);
            tableLayoutOptions.Dock = DockStyle.Fill;
            tableLayoutOptions.Location = new Point(204, 164);
            tableLayoutOptions.Margin = new Padding(4);
            tableLayoutOptions.Name = "tableLayoutOptions";
            tableLayoutOptions.RowCount = 4;
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOptions.Size = new Size(577, 93);
            tableLayoutOptions.TabIndex = 25;
            // 
            // chkOnlyEven
            // 
            chkOnlyEven.Anchor = AnchorStyles.Left;
            chkOnlyEven.AutoSize = true;
            chkOnlyEven.Location = new Point(4, 11);
            chkOnlyEven.Margin = new Padding(4);
            chkOnlyEven.Name = "chkOnlyEven";
            chkOnlyEven.Size = new Size(168, 29);
            chkOnlyEven.TabIndex = 23;
            chkOnlyEven.Text = "Even Pages Only";
            chkOnlyEven.UseVisualStyleBackColor = true;
            chkOnlyEven.CheckedChanged += chkOnlyEven_CheckedChanged;
            // 
            // chkOnlyOdd
            // 
            chkOnlyOdd.Anchor = AnchorStyles.Left;
            chkOnlyOdd.AutoSize = true;
            chkOnlyOdd.Location = new Point(4, 51);
            chkOnlyOdd.Margin = new Padding(4);
            chkOnlyOdd.Name = "chkOnlyOdd";
            chkOnlyOdd.Size = new Size(167, 29);
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
            chkAllowDuplicates.Location = new Point(183, 11);
            chkAllowDuplicates.Margin = new Padding(2);
            chkAllowDuplicates.Name = "chkAllowDuplicates";
            chkAllowDuplicates.Size = new Size(224, 29);
            chkAllowDuplicates.TabIndex = 21;
            chkAllowDuplicates.Text = "Allow Page Duplicates";
            chkAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnSelectDoc
            // 
            btnSelectDoc.AllowDrop = true;
            btnSelectDoc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSelectDoc.Location = new Point(789, 5);
            btnSelectDoc.Margin = new Padding(4, 2, 4, 2);
            btnSelectDoc.MinimumSize = new Size(0, 40);
            btnSelectDoc.Name = "btnSelectDoc";
            btnSelectDoc.Size = new Size(113, 40);
            btnSelectDoc.TabIndex = 2;
            btnSelectDoc.Text = "SELECT";
            btnSelectDoc.UseVisualStyleBackColor = true;
            btnSelectDoc.Click += btnSelect_Click;
            // 
            // btnClearPages
            // 
            btnClearPages.Anchor = AnchorStyles.Left;
            btnClearPages.Font = new Font("Segoe UI", 7F);
            btnClearPages.Location = new Point(789, 117);
            btnClearPages.Margin = new Padding(4, 2, 4, 2);
            btnClearPages.Name = "btnClearPages";
            btnClearPages.Size = new Size(31, 31);
            btnClearPages.TabIndex = 7;
            btnClearPages.Text = "X";
            btnClearPages.UseVisualStyleBackColor = true;
            btnClearPages.Click += btnClearPages_Click;
            // 
            // txtPages
            // 
            txtPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPages.Location = new Point(204, 117);
            txtPages.Margin = new Padding(4, 2, 4, 2);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(577, 31);
            txtPages.TabIndex = 6;
            txtPages.KeyPress += txtPages_KeyPress;
            // 
            // lblDocInfo
            // 
            lblDocInfo.Anchor = AnchorStyles.Right;
            lblDocInfo.AutoSize = true;
            lblDocInfo.Location = new Point(60, 65);
            lblDocInfo.Margin = new Padding(4, 0, 4, 0);
            lblDocInfo.Name = "lblDocInfo";
            lblDocInfo.Size = new Size(136, 25);
            lblDocInfo.TabIndex = 19;
            lblDocInfo.Text = "Document Info:";
            // 
            // lblPages
            // 
            lblPages.Anchor = AnchorStyles.Right;
            lblPages.AutoSize = true;
            lblPages.Location = new Point(54, 120);
            lblPages.Margin = new Padding(4, 0, 4, 0);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(142, 25);
            lblPages.TabIndex = 5;
            lblPages.Text = "Pages To Extract:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(204, 326);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status";
            // 
            // lblPageCount
            // 
            lblPageCount.Anchor = AnchorStyles.Left;
            lblPageCount.AutoSize = true;
            lblPageCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPageCount.Location = new Point(204, 65);
            lblPageCount.Margin = new Padding(4, 0, 4, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(73, 25);
            lblPageCount.TabIndex = 18;
            lblPageCount.Text = "0 pages";
            // 
            // lblOptions
            // 
            lblOptions.Anchor = AnchorStyles.Right;
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(116, 198);
            lblOptions.Margin = new Padding(4, 0, 4, 0);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(80, 25);
            lblOptions.TabIndex = 24;
            lblOptions.Text = "Options:";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnReload.Font = new Font("Segoe UI", 8F);
            btnReload.Location = new Point(787, 61);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(117, 32);
            btnReload.TabIndex = 25;
            btnReload.Text = "RELOAD";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // lblExclude
            // 
            lblExclude.Anchor = AnchorStyles.Right;
            lblExclude.AutoSize = true;
            lblExclude.Location = new Point(48, 276);
            lblExclude.Name = "lblExclude";
            lblExclude.Size = new Size(149, 25);
            lblExclude.TabIndex = 27;
            lblExclude.Text = "Pages To Exclude:";
            // 
            // txtExclude
            // 
            txtExclude.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtExclude.Location = new Point(203, 273);
            txtExclude.Name = "txtExclude";
            txtExclude.Size = new Size(579, 31);
            txtExclude.TabIndex = 28;
            txtExclude.KeyPress += txtExclude_KeyPress;
            // 
            // btnAdvanced
            // 
            btnAdvanced.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdvanced.Font = new Font("Segoe UI", 8F);
            btnAdvanced.Location = new Point(788, 193);
            btnAdvanced.Name = "btnAdvanced";
            btnAdvanced.Size = new Size(115, 34);
            btnAdvanced.TabIndex = 26;
            btnAdvanced.Text = "ADVANCED";
            btnAdvanced.UseVisualStyleBackColor = true;
            btnAdvanced.Click += btnAdvanced_Click;
            // 
            // btnClearExclude
            // 
            btnClearExclude.Anchor = AnchorStyles.Left;
            btnClearExclude.Font = new Font("Segoe UI", 7F);
            btnClearExclude.Location = new Point(788, 273);
            btnClearExclude.Name = "btnClearExclude";
            btnClearExclude.Size = new Size(31, 31);
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
            tableLayoutDrag.Location = new Point(3, 3);
            tableLayoutDrag.Name = "tableLayoutDrag";
            tableLayoutDrag.RowCount = 2;
            tableLayoutDrag.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutDrag.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDrag.Size = new Size(259, 465);
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
            panelDrag.Size = new Size(259, 350);
            panelDrag.TabIndex = 25;
            panelDrag.DragDrop += btnSelectDoc_DragDrop;
            panelDrag.DragEnter += btnSelectDoc_DragEnter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 265F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutDrag, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutDetails, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1179, 471);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // TAB_EXTRACT_PDF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnExtract);
            Margin = new Padding(4, 2, 4, 2);
            Name = "TAB_EXTRACT_PDF";
            Size = new Size(1179, 536);
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

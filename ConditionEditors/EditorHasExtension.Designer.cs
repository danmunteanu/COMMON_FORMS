namespace CommonForms
{
    partial class EditorHasExtension
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
            lblAddExtension = new Label();
            txtAddExt = new TextBox();
            btnAddExt = new Button();
            btnClearExt = new Button();
            lblExtensionList = new Label();
            btnPdf = new Button();
            btnMd = new Button();
            btnTxt = new Button();
            btnImages = new Button();
            txtExtensions = new TextBox();
            btnDocExt = new Button();
            btnTextExt = new Button();
            tableLayoutExtButtons = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanelAdd = new TableLayoutPanel();
            flowLayoutSingleExtensions = new FlowLayoutPanel();
            tableLayoutExtButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelAdd.SuspendLayout();
            flowLayoutSingleExtensions.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddExtension
            // 
            lblAddExtension.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddExtension.AutoSize = true;
            lblAddExtension.Location = new Point(18, 325);
            lblAddExtension.Name = "lblAddExtension";
            lblAddExtension.Size = new Size(87, 25);
            lblAddExtension.TabIndex = 0;
            lblAddExtension.Text = "Extension";
            // 
            // txtAddExt
            // 
            txtAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddExt.Location = new Point(3, 3);
            txtAddExt.Name = "txtAddExt";
            txtAddExt.Size = new Size(407, 31);
            txtAddExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(416, 3);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(99, 28);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // btnClearExt
            // 
            btnClearExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(451, 3);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(64, 28);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(18, 30);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(126, 25);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extensions List";
            // 
            // btnPdf
            // 
            btnPdf.Font = new Font("Segoe UI", 7F);
            btnPdf.Location = new Point(133, 3);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(59, 29);
            btnPdf.TabIndex = 8;
            btnPdf.Text = "pdf";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnMd
            // 
            btnMd.Font = new Font("Segoe UI", 7F);
            btnMd.Location = new Point(68, 3);
            btnMd.Name = "btnMd";
            btnMd.Size = new Size(59, 29);
            btnMd.TabIndex = 7;
            btnMd.Text = "md";
            btnMd.UseVisualStyleBackColor = true;
            btnMd.Click += btnMd_Click;
            // 
            // btnTxt
            // 
            btnTxt.Font = new Font("Segoe UI", 7F);
            btnTxt.Location = new Point(3, 3);
            btnTxt.Name = "btnTxt";
            btnTxt.Size = new Size(59, 29);
            btnTxt.TabIndex = 6;
            btnTxt.Text = "txt";
            btnTxt.UseVisualStyleBackColor = true;
            btnTxt.Click += btnTxt_Click;
            // 
            // btnImages
            // 
            btnImages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnImages.Font = new Font("Segoe UI", 7F);
            btnImages.Location = new Point(3, 3);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(69, 27);
            btnImages.TabIndex = 9;
            btnImages.Text = "IMAGES";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // txtExtensions
            // 
            txtExtensions.Dock = DockStyle.Fill;
            txtExtensions.Location = new Point(18, 58);
            txtExtensions.Multiline = true;
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(518, 64);
            txtExtensions.TabIndex = 10;
            // 
            // btnDocExt
            // 
            btnDocExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDocExt.Font = new Font("Segoe UI", 7F);
            btnDocExt.Location = new Point(78, 3);
            btnDocExt.Name = "btnDocExt";
            btnDocExt.Size = new Size(54, 27);
            btnDocExt.TabIndex = 11;
            btnDocExt.Text = "DOCS";
            btnDocExt.UseVisualStyleBackColor = true;
            btnDocExt.Click += btnDocExt_Click;
            // 
            // btnTextExt
            // 
            btnTextExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTextExt.Font = new Font("Segoe UI", 7F);
            btnTextExt.Location = new Point(138, 3);
            btnTextExt.Name = "btnTextExt";
            btnTextExt.Size = new Size(44, 27);
            btnTextExt.TabIndex = 12;
            btnTextExt.Text = "TXT";
            btnTextExt.UseVisualStyleBackColor = true;
            btnTextExt.Click += btnTextExt_Click;
            // 
            // tableLayoutExtButtons
            // 
            tableLayoutExtButtons.ColumnCount = 5;
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutExtButtons.Controls.Add(btnImages, 0, 0);
            tableLayoutExtButtons.Controls.Add(btnClearExt, 4, 0);
            tableLayoutExtButtons.Controls.Add(btnDocExt, 1, 0);
            tableLayoutExtButtons.Controls.Add(btnTextExt, 2, 0);
            tableLayoutExtButtons.Dock = DockStyle.Fill;
            tableLayoutExtButtons.Location = new Point(18, 128);
            tableLayoutExtButtons.Name = "tableLayoutExtButtons";
            tableLayoutExtButtons.RowCount = 1;
            tableLayoutExtButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.Size = new Size(518, 34);
            tableLayoutExtButtons.TabIndex = 13;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutMain.Controls.Add(tableLayoutPanelAdd, 1, 7);
            tableLayoutMain.Controls.Add(flowLayoutSingleExtensions, 1, 4);
            tableLayoutMain.Controls.Add(lblExtensionList, 1, 1);
            tableLayoutMain.Controls.Add(txtExtensions, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutExtButtons, 1, 3);
            tableLayoutMain.Controls.Add(lblAddExtension, 1, 6);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 9;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.Size = new Size(554, 405);
            tableLayoutMain.TabIndex = 14;
            // 
            // tableLayoutPanelAdd
            // 
            tableLayoutPanelAdd.ColumnCount = 2;
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanelAdd.Controls.Add(btnAddExt, 1, 0);
            tableLayoutPanelAdd.Controls.Add(txtAddExt, 0, 0);
            tableLayoutPanelAdd.Dock = DockStyle.Fill;
            tableLayoutPanelAdd.Location = new Point(18, 353);
            tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            tableLayoutPanelAdd.RowCount = 1;
            tableLayoutPanelAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.Size = new Size(518, 34);
            tableLayoutPanelAdd.TabIndex = 15;
            // 
            // flowLayoutSingleExtensions
            // 
            flowLayoutSingleExtensions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutSingleExtensions.Controls.Add(btnTxt);
            flowLayoutSingleExtensions.Controls.Add(btnMd);
            flowLayoutSingleExtensions.Controls.Add(btnPdf);
            flowLayoutSingleExtensions.Location = new Point(18, 168);
            flowLayoutSingleExtensions.Name = "flowLayoutSingleExtensions";
            flowLayoutSingleExtensions.Size = new Size(518, 29);
            flowLayoutSingleExtensions.TabIndex = 15;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorHasExtension";
            Size = new Size(554, 405);
            tableLayoutExtButtons.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutPanelAdd.ResumeLayout(false);
            tableLayoutPanelAdd.PerformLayout();
            flowLayoutSingleExtensions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAddExtension;
        private TextBox txtAddExt;
        private Button btnAddExt;
        private Button btnClearExt;
        private Label lblExtensionList;
        private Button btnTxt;
        private Button btnMd;
        private Button btnPdf;
        private Button btnImages;
        private TextBox txtExtensions;
        private Button btnDocExt;
        private Button btnTextExt;
        private TableLayoutPanel tableLayoutExtButtons;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutPanelAdd;
        private FlowLayoutPanel flowLayoutSingleExtensions;
    }
}

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
            txtAddExt = new TextBox();
            btnAddExt = new Button();
            btnClearExt = new Button();
            lblExtensionList = new Label();
            btnImages = new Button();
            txtExtensions = new TextBox();
            btnDocExt = new Button();
            btnTextExt = new Button();
            tableLayoutExtButtons = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanelAdd = new TableLayoutPanel();
            lblExt = new Label();
            tableLayoutExtButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddExt
            // 
            txtAddExt.Dock = DockStyle.Fill;
            txtAddExt.Font = new Font("Segoe UI", 7F);
            txtAddExt.Location = new Point(381, 3);
            txtAddExt.Name = "txtAddExt";
            txtAddExt.Size = new Size(64, 26);
            txtAddExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Dock = DockStyle.Fill;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(451, 3);
            btnAddExt.Name = "btnAddExt";
            btnAddExt.Size = new Size(54, 28);
            btnAddExt.TabIndex = 2;
            btnAddExt.Text = "ADD";
            btnAddExt.UseVisualStyleBackColor = true;
            btnAddExt.Click += btnAddExt_Click;
            // 
            // btnClearExt
            // 
            btnClearExt.Dock = DockStyle.Fill;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(436, 3);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(69, 28);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(3, 4);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(126, 25);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extensions List";
            // 
            // btnImages
            // 
            btnImages.Dock = DockStyle.Fill;
            btnImages.Font = new Font("Segoe UI", 7F);
            btnImages.Location = new Point(123, 3);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(69, 28);
            btnImages.TabIndex = 9;
            btnImages.Text = "IMAGES";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // txtExtensions
            // 
            txtExtensions.Dock = DockStyle.Fill;
            txtExtensions.Location = new Point(23, 63);
            txtExtensions.Multiline = true;
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(508, 64);
            txtExtensions.TabIndex = 10;
            // 
            // btnDocExt
            // 
            btnDocExt.Dock = DockStyle.Fill;
            btnDocExt.Font = new Font("Segoe UI", 7F);
            btnDocExt.Location = new Point(3, 3);
            btnDocExt.Name = "btnDocExt";
            btnDocExt.Size = new Size(54, 28);
            btnDocExt.TabIndex = 11;
            btnDocExt.Text = "DOCS";
            btnDocExt.UseVisualStyleBackColor = true;
            btnDocExt.Click += btnDocExt_Click;
            // 
            // btnTextExt
            // 
            btnTextExt.Dock = DockStyle.Fill;
            btnTextExt.Font = new Font("Segoe UI", 7F);
            btnTextExt.Location = new Point(63, 3);
            btnTextExt.Name = "btnTextExt";
            btnTextExt.Size = new Size(54, 28);
            btnTextExt.TabIndex = 12;
            btnTextExt.Text = "YAML";
            btnTextExt.UseVisualStyleBackColor = true;
            btnTextExt.Click += btnTextExt_Click;
            // 
            // tableLayoutExtButtons
            // 
            tableLayoutExtButtons.ColumnCount = 5;
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutExtButtons.Controls.Add(btnClearExt, 4, 0);
            tableLayoutExtButtons.Controls.Add(btnImages, 2, 0);
            tableLayoutExtButtons.Controls.Add(btnTextExt, 1, 0);
            tableLayoutExtButtons.Controls.Add(btnDocExt, 0, 0);
            tableLayoutExtButtons.Dock = DockStyle.Fill;
            tableLayoutExtButtons.Location = new Point(23, 133);
            tableLayoutExtButtons.Name = "tableLayoutExtButtons";
            tableLayoutExtButtons.RowCount = 1;
            tableLayoutExtButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.Size = new Size(508, 34);
            tableLayoutExtButtons.TabIndex = 13;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Controls.Add(txtExtensions, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutExtButtons, 1, 3);
            tableLayoutMain.Controls.Add(tableLayoutPanelAdd, 1, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 6;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.Size = new Size(554, 405);
            tableLayoutMain.TabIndex = 14;
            // 
            // tableLayoutPanelAdd
            // 
            tableLayoutPanelAdd.ColumnCount = 5;
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelAdd.Controls.Add(btnAddExt, 4, 0);
            tableLayoutPanelAdd.Controls.Add(lblExtensionList, 0, 0);
            tableLayoutPanelAdd.Controls.Add(txtAddExt, 3, 0);
            tableLayoutPanelAdd.Controls.Add(lblExt, 2, 0);
            tableLayoutPanelAdd.Dock = DockStyle.Fill;
            tableLayoutPanelAdd.Location = new Point(23, 23);
            tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            tableLayoutPanelAdd.RowCount = 1;
            tableLayoutPanelAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.Size = new Size(508, 34);
            tableLayoutPanelAdd.TabIndex = 15;
            // 
            // lblExt
            // 
            lblExt.Anchor = AnchorStyles.Right;
            lblExt.AutoSize = true;
            lblExt.Font = new Font("Segoe UI", 9F);
            lblExt.Location = new Point(324, 0);
            lblExt.Name = "lblExt";
            lblExt.Size = new Size(51, 34);
            lblExt.TabIndex = 6;
            lblExt.Text = "Add Ext:";
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
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtAddExt;
        private Button btnAddExt;
        private Button btnClearExt;
        private Label lblExtensionList;
        private Button btnImages;
        private TextBox txtExtensions;
        private Button btnDocExt;
        private Button btnTextExt;
        private TableLayoutPanel tableLayoutExtButtons;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutPanelAdd;
        private Label lblExt;
    }
}

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
            btnArchives = new Button();
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
            txtAddExt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddExt.Font = new Font("Segoe UI", 7F);
            txtAddExt.Location = new Point(421, 4);
            txtAddExt.Name = "txtAddExt";
            txtAddExt.Size = new Size(64, 26);
            txtAddExt.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Dock = DockStyle.Fill;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(491, 3);
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
            btnClearExt.Location = new Point(476, 3);
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
            lblExtensionList.Location = new Point(3, 0);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(92, 34);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extension List";
            // 
            // btnImages
            // 
            btnImages.Dock = DockStyle.Fill;
            btnImages.Font = new Font("Segoe UI", 7F);
            btnImages.Location = new Point(198, 3);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(75, 28);
            btnImages.TabIndex = 9;
            btnImages.Text = "IMAGES";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // txtExtensions
            // 
            txtExtensions.Dock = DockStyle.Fill;
            txtExtensions.Location = new Point(3, 119);
            txtExtensions.Multiline = true;
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(548, 64);
            txtExtensions.TabIndex = 10;
            // 
            // btnDocExt
            // 
            btnDocExt.Dock = DockStyle.Fill;
            btnDocExt.Font = new Font("Segoe UI", 7F);
            btnDocExt.Location = new Point(63, 3);
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
            btnTextExt.Location = new Point(3, 3);
            btnTextExt.Name = "btnTextExt";
            btnTextExt.Size = new Size(54, 28);
            btnTextExt.TabIndex = 12;
            btnTextExt.Text = "YAML";
            btnTextExt.UseVisualStyleBackColor = true;
            btnTextExt.Click += btnTextExt_Click;
            // 
            // tableLayoutExtButtons
            // 
            tableLayoutExtButtons.ColumnCount = 6;
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutExtButtons.Controls.Add(btnClearExt, 5, 0);
            tableLayoutExtButtons.Controls.Add(btnDocExt, 1, 0);
            tableLayoutExtButtons.Controls.Add(btnTextExt, 0, 0);
            tableLayoutExtButtons.Controls.Add(btnImages, 3, 0);
            tableLayoutExtButtons.Controls.Add(btnArchives, 2, 0);
            tableLayoutExtButtons.Dock = DockStyle.Fill;
            tableLayoutExtButtons.Location = new Point(3, 189);
            tableLayoutExtButtons.Name = "tableLayoutExtButtons";
            tableLayoutExtButtons.RowCount = 1;
            tableLayoutExtButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.Size = new Size(548, 34);
            tableLayoutExtButtons.TabIndex = 13;
            // 
            // btnArchives
            // 
            btnArchives.Dock = DockStyle.Fill;
            btnArchives.Font = new Font("Segoe UI", 7F);
            btnArchives.Location = new Point(123, 3);
            btnArchives.Name = "btnArchives";
            btnArchives.Size = new Size(69, 28);
            btnArchives.TabIndex = 13;
            btnArchives.Text = "ARCHIVES";
            btnArchives.UseVisualStyleBackColor = true;
            btnArchives.Click += btnArchives_Click;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutMain.Controls.Add(txtExtensions, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutExtButtons, 1, 3);
            tableLayoutMain.Controls.Add(tableLayoutPanelAdd, 1, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.Size = new Size(554, 405);
            tableLayoutMain.TabIndex = 14;
            // 
            // tableLayoutPanelAdd
            // 
            tableLayoutPanelAdd.ColumnCount = 5;
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelAdd.Controls.Add(btnAddExt, 4, 0);
            tableLayoutPanelAdd.Controls.Add(lblExtensionList, 0, 0);
            tableLayoutPanelAdd.Controls.Add(txtAddExt, 3, 0);
            tableLayoutPanelAdd.Controls.Add(lblExt, 2, 0);
            tableLayoutPanelAdd.Dock = DockStyle.Fill;
            tableLayoutPanelAdd.Location = new Point(3, 79);
            tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            tableLayoutPanelAdd.RowCount = 1;
            tableLayoutPanelAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.Size = new Size(548, 34);
            tableLayoutPanelAdd.TabIndex = 15;
            // 
            // lblExt
            // 
            lblExt.Anchor = AnchorStyles.Right;
            lblExt.AutoSize = true;
            lblExt.Font = new Font("Segoe UI", 9F);
            lblExt.Location = new Point(364, 0);
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
        private Button btnArchives;
    }
}

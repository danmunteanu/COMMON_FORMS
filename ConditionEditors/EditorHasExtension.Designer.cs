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
            txtAddExtension = new TextBox();
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
            tableLayoutPanelButtonsAndList = new TableLayoutPanel();
            tableLayoutPanelButtonList = new TableLayoutPanel();
            tableLayoutPanelList = new TableLayoutPanel();
            tableLayoutExtButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelAdd.SuspendLayout();
            tableLayoutPanelButtonsAndList.SuspendLayout();
            tableLayoutPanelButtonList.SuspendLayout();
            tableLayoutPanelList.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddExt
            // 
            txtAddExtension.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddExtension.Font = new Font("Segoe UI", 7F);
            txtAddExtension.Location = new Point(329, 4);
            txtAddExtension.Name = "txtAddExt";
            txtAddExtension.Size = new Size(64, 26);
            txtAddExtension.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Dock = DockStyle.Fill;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(399, 3);
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
            btnClearExt.Location = new Point(270, 0);
            btnClearExt.Margin = new Padding(0, 0, 0, 0);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(80, 35);
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
            lblExtensionList.Size = new Size(99, 25);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extensions:";
            // 
            // btnImages
            // 
            btnImages.Dock = DockStyle.Fill;
            btnImages.Font = new Font("Segoe UI", 7F);
            btnImages.Location = new Point(3, 73);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(88, 29);
            btnImages.TabIndex = 9;
            btnImages.Text = "IMAGES";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // txtExtensions
            // 
            txtExtensions.Dock = DockStyle.Fill;
            txtExtensions.Location = new Point(3, 3);
            txtExtensions.Multiline = true;
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(344, 97);
            txtExtensions.TabIndex = 10;
            // 
            // btnDocExt
            // 
            btnDocExt.Dock = DockStyle.Fill;
            btnDocExt.Font = new Font("Segoe UI", 7F);
            btnDocExt.Location = new Point(3, 38);
            btnDocExt.Name = "btnDocExt";
            btnDocExt.Size = new Size(88, 29);
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
            btnTextExt.Size = new Size(88, 29);
            btnTextExt.TabIndex = 12;
            btnTextExt.Text = "YAML";
            btnTextExt.UseVisualStyleBackColor = true;
            btnTextExt.Click += btnTextExt_Click;
            // 
            // tableLayoutExtButtons
            // 
            tableLayoutExtButtons.ColumnCount = 2;
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutExtButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutExtButtons.Controls.Add(btnClearExt, 1, 0);
            tableLayoutExtButtons.Dock = DockStyle.Fill;
            tableLayoutExtButtons.Location = new Point(0, 103);
            tableLayoutExtButtons.Margin = new Padding(0, 0, 0, 0);
            tableLayoutExtButtons.Name = "tableLayoutExtButtons";
            tableLayoutExtButtons.RowCount = 1;
            tableLayoutExtButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutExtButtons.Size = new Size(350, 35);
            tableLayoutExtButtons.TabIndex = 13;
            // 
            // btnArchives
            // 
            btnArchives.Dock = DockStyle.Fill;
            btnArchives.Font = new Font("Segoe UI", 7F);
            btnArchives.Location = new Point(3, 108);
            btnArchives.Name = "btnArchives";
            btnArchives.Size = new Size(88, 29);
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
            tableLayoutMain.Controls.Add(tableLayoutPanelButtonsAndList, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutPanelAdd, 1, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(462, 342);
            tableLayoutMain.TabIndex = 14;
            // 
            // tableLayoutPanelAdd
            // 
            tableLayoutPanelAdd.ColumnCount = 5;
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelAdd.Controls.Add(btnAddExt, 4, 0);
            tableLayoutPanelAdd.Controls.Add(lblExtensionList, 0, 0);
            tableLayoutPanelAdd.Controls.Add(txtAddExtension, 3, 0);
            tableLayoutPanelAdd.Controls.Add(lblExt, 2, 0);
            tableLayoutPanelAdd.Dock = DockStyle.Fill;
            tableLayoutPanelAdd.Location = new Point(3, 48);
            tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            tableLayoutPanelAdd.RowCount = 1;
            tableLayoutPanelAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.Size = new Size(456, 34);
            tableLayoutPanelAdd.TabIndex = 15;
            // 
            // lblExt
            // 
            lblExt.Anchor = AnchorStyles.Right;
            lblExt.AutoSize = true;
            lblExt.Font = new Font("Segoe UI", 9F);
            lblExt.Location = new Point(273, 4);
            lblExt.Name = "lblExt";
            lblExt.Size = new Size(50, 25);
            lblExt.TabIndex = 6;
            lblExt.Text = "Add:";
            // 
            // tableLayoutPanelButtonsAndList
            // 
            tableLayoutPanelButtonsAndList.ColumnCount = 2;
            tableLayoutPanelButtonsAndList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanelButtonsAndList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndList.Controls.Add(tableLayoutPanelList, 1, 0);
            tableLayoutPanelButtonsAndList.Controls.Add(tableLayoutPanelButtonList, 0, 0);
            tableLayoutPanelButtonsAndList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonsAndList.Location = new Point(3, 88);
            tableLayoutPanelButtonsAndList.Name = "tableLayoutPanelButtonsAndList";
            tableLayoutPanelButtonsAndList.RowCount = 1;
            tableLayoutPanelButtonsAndList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndList.Size = new Size(456, 144);
            tableLayoutPanelButtonsAndList.TabIndex = 16;
            // 
            // tableLayoutPanelButtonList
            // 
            tableLayoutPanelButtonList.ColumnCount = 1;
            tableLayoutPanelButtonList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.Controls.Add(btnTextExt, 0, 0);
            tableLayoutPanelButtonList.Controls.Add(btnDocExt, 0, 1);
            tableLayoutPanelButtonList.Controls.Add(btnImages, 0, 2);
            tableLayoutPanelButtonList.Controls.Add(btnArchives, 0, 3);
            tableLayoutPanelButtonList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonList.Location = new Point(3, 3);
            tableLayoutPanelButtonList.Name = "tableLayoutPanelButtonList";
            tableLayoutPanelButtonList.RowCount = 5;
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.Size = new Size(94, 138);
            tableLayoutPanelButtonList.TabIndex = 17;
            // 
            // tableLayoutPanelList
            // 
            tableLayoutPanelList.ColumnCount = 1;
            tableLayoutPanelList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.Controls.Add(txtExtensions, 0, 0);
            tableLayoutPanelList.Controls.Add(tableLayoutExtButtons, 0, 1);
            tableLayoutPanelList.Dock = DockStyle.Fill;
            tableLayoutPanelList.Location = new Point(103, 3);
            tableLayoutPanelList.Name = "tableLayoutPanelList";
            tableLayoutPanelList.RowCount = 2;
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelList.Size = new Size(350, 138);
            tableLayoutPanelList.TabIndex = 18;
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorHasExtension";
            Size = new Size(462, 342);
            tableLayoutExtButtons.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanelAdd.ResumeLayout(false);
            tableLayoutPanelAdd.PerformLayout();
            tableLayoutPanelButtonsAndList.ResumeLayout(false);
            tableLayoutPanelButtonList.ResumeLayout(false);
            tableLayoutPanelList.ResumeLayout(false);
            tableLayoutPanelList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtAddExtension;
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
        private TableLayoutPanel tableLayoutPanelButtonsAndList;
        private TableLayoutPanel tableLayoutPanelButtonList;
        private TableLayoutPanel tableLayoutPanelList;
    }
}

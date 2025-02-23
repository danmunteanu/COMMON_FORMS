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
            btnArchives = new Button();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanelButtonsAndList = new TableLayoutPanel();
            tableLayoutPanelList = new TableLayoutPanel();
            tableLayoutPanelButtonList = new TableLayoutPanel();
            btnAudio = new Button();
            tableLayoutPanelAdd = new TableLayoutPanel();
            lblExt = new Label();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelButtonsAndList.SuspendLayout();
            tableLayoutPanelList.SuspendLayout();
            tableLayoutPanelButtonList.SuspendLayout();
            tableLayoutPanelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddExtension
            // 
            txtAddExtension.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddExtension.Font = new Font("Segoe UI", 7F);
            txtAddExtension.Location = new Point(615, 5);
            txtAddExtension.Name = "txtAddExtension";
            txtAddExtension.Size = new Size(64, 23);
            txtAddExtension.TabIndex = 1;
            // 
            // btnAddExt
            // 
            btnAddExt.Dock = DockStyle.Fill;
            btnAddExt.Font = new Font("Segoe UI", 7F);
            btnAddExt.Location = new Point(685, 3);
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
            btnClearExt.Location = new Point(0, 208);
            btnClearExt.Margin = new Padding(0);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(84, 30);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // lblExtensionList
            // 
            lblExtensionList.Anchor = AnchorStyles.Left;
            lblExtensionList.AutoSize = true;
            lblExtensionList.Location = new Point(3, 7);
            lblExtensionList.Name = "lblExtensionList";
            lblExtensionList.Size = new Size(81, 20);
            lblExtensionList.TabIndex = 5;
            lblExtensionList.Text = "Extensions:";
            // 
            // btnImages
            // 
            btnImages.Dock = DockStyle.Fill;
            btnImages.Font = new Font("Segoe UI", 7F);
            btnImages.Location = new Point(3, 63);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(78, 24);
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
            txtExtensions.Size = new Size(640, 232);
            txtExtensions.TabIndex = 10;
            txtExtensions.TextChanged += txtExtensions_TextChanged;
            // 
            // btnDocExt
            // 
            btnDocExt.Dock = DockStyle.Fill;
            btnDocExt.Font = new Font("Segoe UI", 7F);
            btnDocExt.Location = new Point(3, 33);
            btnDocExt.Name = "btnDocExt";
            btnDocExt.Size = new Size(78, 24);
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
            btnTextExt.Size = new Size(78, 24);
            btnTextExt.TabIndex = 12;
            btnTextExt.Text = "YAML";
            btnTextExt.UseVisualStyleBackColor = true;
            btnTextExt.Click += btnTextExt_Click;
            // 
            // btnArchives
            // 
            btnArchives.Dock = DockStyle.Fill;
            btnArchives.Font = new Font("Segoe UI", 7F);
            btnArchives.Location = new Point(3, 93);
            btnArchives.Name = "btnArchives";
            btnArchives.Size = new Size(78, 24);
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
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.Size = new Size(748, 442);
            tableLayoutMain.TabIndex = 14;
            // 
            // tableLayoutPanelButtonsAndList
            // 
            tableLayoutPanelButtonsAndList.ColumnCount = 2;
            tableLayoutPanelButtonsAndList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelButtonsAndList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndList.Controls.Add(tableLayoutPanelList, 1, 0);
            tableLayoutPanelButtonsAndList.Controls.Add(tableLayoutPanelButtonList, 0, 0);
            tableLayoutPanelButtonsAndList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonsAndList.Location = new Point(3, 88);
            tableLayoutPanelButtonsAndList.Name = "tableLayoutPanelButtonsAndList";
            tableLayoutPanelButtonsAndList.RowCount = 1;
            tableLayoutPanelButtonsAndList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndList.Size = new Size(742, 244);
            tableLayoutPanelButtonsAndList.TabIndex = 16;
            // 
            // tableLayoutPanelList
            // 
            tableLayoutPanelList.ColumnCount = 1;
            tableLayoutPanelList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.Controls.Add(txtExtensions, 0, 0);
            tableLayoutPanelList.Dock = DockStyle.Fill;
            tableLayoutPanelList.Location = new Point(93, 3);
            tableLayoutPanelList.Name = "tableLayoutPanelList";
            tableLayoutPanelList.RowCount = 1;
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelList.Size = new Size(646, 238);
            tableLayoutPanelList.TabIndex = 18;
            // 
            // tableLayoutPanelButtonList
            // 
            tableLayoutPanelButtonList.ColumnCount = 1;
            tableLayoutPanelButtonList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.Controls.Add(btnClearExt, 0, 6);
            tableLayoutPanelButtonList.Controls.Add(btnAudio, 0, 4);
            tableLayoutPanelButtonList.Controls.Add(btnTextExt, 0, 0);
            tableLayoutPanelButtonList.Controls.Add(btnDocExt, 0, 1);
            tableLayoutPanelButtonList.Controls.Add(btnImages, 0, 2);
            tableLayoutPanelButtonList.Controls.Add(btnArchives, 0, 3);
            tableLayoutPanelButtonList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonList.Location = new Point(3, 3);
            tableLayoutPanelButtonList.Name = "tableLayoutPanelButtonList";
            tableLayoutPanelButtonList.RowCount = 7;
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.Size = new Size(84, 238);
            tableLayoutPanelButtonList.TabIndex = 17;
            // 
            // btnAudio
            // 
            btnAudio.Dock = DockStyle.Fill;
            btnAudio.Font = new Font("Segoe UI", 7F);
            btnAudio.Location = new Point(3, 123);
            btnAudio.Name = "btnAudio";
            btnAudio.Size = new Size(78, 24);
            btnAudio.TabIndex = 14;
            btnAudio.Text = "AUDIO";
            btnAudio.UseVisualStyleBackColor = true;
            btnAudio.Click += btnAudio_Click;
            // 
            // tableLayoutPanelAdd
            // 
            tableLayoutPanelAdd.ColumnCount = 5;
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanelAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelAdd.Controls.Add(btnAddExt, 4, 0);
            tableLayoutPanelAdd.Controls.Add(txtAddExtension, 3, 0);
            tableLayoutPanelAdd.Controls.Add(lblExt, 2, 0);
            tableLayoutPanelAdd.Controls.Add(lblExtensionList, 0, 0);
            tableLayoutPanelAdd.Dock = DockStyle.Fill;
            tableLayoutPanelAdd.Location = new Point(3, 48);
            tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            tableLayoutPanelAdd.RowCount = 1;
            tableLayoutPanelAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAdd.Size = new Size(742, 34);
            tableLayoutPanelAdd.TabIndex = 15;
            // 
            // lblExt
            // 
            lblExt.Anchor = AnchorStyles.Right;
            lblExt.AutoSize = true;
            lblExt.Font = new Font("Segoe UI", 9F);
            lblExt.Location = new Point(569, 7);
            lblExt.Name = "lblExt";
            lblExt.Size = new Size(40, 20);
            lblExt.TabIndex = 6;
            lblExt.Text = "Add:";
            // 
            // EditorHasExtension
            // 
            Controls.Add(tableLayoutMain);
            Name = "EditorHasExtension";
            Size = new Size(748, 442);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanelButtonsAndList.ResumeLayout(false);
            tableLayoutPanelList.ResumeLayout(false);
            tableLayoutPanelList.PerformLayout();
            tableLayoutPanelButtonList.ResumeLayout(false);
            tableLayoutPanelAdd.ResumeLayout(false);
            tableLayoutPanelAdd.PerformLayout();
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
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutPanelAdd;
        private Label lblExt;
        private Button btnArchives;
        private TableLayoutPanel tableLayoutPanelButtonsAndList;
        private TableLayoutPanel tableLayoutPanelButtonList;
        private TableLayoutPanel tableLayoutPanelList;
        private Button btnAudio;
    }
}

namespace CommonForms.Components
{
    partial class ExtensionsList
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
            tableLayoutPanelButtonsAndList = new TableLayoutPanel();
            tableLayoutPanelList = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClearExt = new Button();
            txtExtensions = new TextBox();
            tableLayoutPanelButtonList = new TableLayoutPanel();
            btnAudio = new Button();
            btnTextExt = new Button();
            btnDocExt = new Button();
            btnImages = new Button();
            btnArchives = new Button();
            tableLayoutPanelButtonsAndList.SuspendLayout();
            tableLayoutPanelList.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelButtonList.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelButtonsAndList
            // 
            tableLayoutPanelButtonsAndList.ColumnCount = 2;
            tableLayoutPanelButtonsAndList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelButtonsAndList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndList.Controls.Add(tableLayoutPanelList, 1, 0);
            tableLayoutPanelButtonsAndList.Controls.Add(tableLayoutPanelButtonList, 0, 0);
            tableLayoutPanelButtonsAndList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonsAndList.Location = new Point(0, 0);
            tableLayoutPanelButtonsAndList.Name = "tableLayoutPanelButtonsAndList";
            tableLayoutPanelButtonsAndList.RowCount = 1;
            tableLayoutPanelButtonsAndList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonsAndList.Size = new Size(415, 262);
            tableLayoutPanelButtonsAndList.TabIndex = 17;
            // 
            // tableLayoutPanelList
            // 
            tableLayoutPanelList.ColumnCount = 1;
            tableLayoutPanelList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanelList.Controls.Add(txtExtensions, 0, 0);
            tableLayoutPanelList.Dock = DockStyle.Fill;
            tableLayoutPanelList.Location = new Point(93, 3);
            tableLayoutPanelList.Name = "tableLayoutPanelList";
            tableLayoutPanelList.RowCount = 2;
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelList.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelList.Size = new Size(319, 256);
            tableLayoutPanelList.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(btnClearExt, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 227);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(313, 26);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // btnClearExt
            // 
            btnClearExt.Dock = DockStyle.Fill;
            btnClearExt.Font = new Font("Segoe UI", 7F);
            btnClearExt.Location = new Point(253, 0);
            btnClearExt.Margin = new Padding(0);
            btnClearExt.Name = "btnClearExt";
            btnClearExt.Size = new Size(60, 26);
            btnClearExt.TabIndex = 3;
            btnClearExt.Text = "CLEAR";
            btnClearExt.UseVisualStyleBackColor = true;
            btnClearExt.Click += btnClearExt_Click;
            // 
            // txtExtensions
            // 
            txtExtensions.Dock = DockStyle.Fill;
            txtExtensions.Location = new Point(3, 3);
            txtExtensions.Multiline = true;
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(313, 218);
            txtExtensions.TabIndex = 10;
            // 
            // tableLayoutPanelButtonList
            // 
            tableLayoutPanelButtonList.ColumnCount = 1;
            tableLayoutPanelButtonList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.Controls.Add(btnAudio, 0, 4);
            tableLayoutPanelButtonList.Controls.Add(btnTextExt, 0, 0);
            tableLayoutPanelButtonList.Controls.Add(btnDocExt, 0, 1);
            tableLayoutPanelButtonList.Controls.Add(btnImages, 0, 2);
            tableLayoutPanelButtonList.Controls.Add(btnArchives, 0, 3);
            tableLayoutPanelButtonList.Dock = DockStyle.Fill;
            tableLayoutPanelButtonList.Location = new Point(3, 3);
            tableLayoutPanelButtonList.Name = "tableLayoutPanelButtonList";
            tableLayoutPanelButtonList.RowCount = 6;
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtonList.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelButtonList.Size = new Size(84, 256);
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
            btnTextExt.Click += btnYamlExt_Click;
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
            // ExtensionsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelButtonsAndList);
            Name = "ExtensionsList";
            Size = new Size(415, 262);
            tableLayoutPanelButtonsAndList.ResumeLayout(false);
            tableLayoutPanelList.ResumeLayout(false);
            tableLayoutPanelList.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanelButtonList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelButtonsAndList;
        private TableLayoutPanel tableLayoutPanelList;
        private TextBox txtExtensions;
        private TableLayoutPanel tableLayoutPanelButtonList;
        private Button btnClearExt;
        private Button btnAudio;
        private Button btnTextExt;
        private Button btnDocExt;
        private Button btnImages;
        private Button btnArchives;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

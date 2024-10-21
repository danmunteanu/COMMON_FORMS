namespace CommonForms
{
    partial class EditorMergeFiles
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
            label1 = new Label();
            label2 = new Label();
            txtMergeName = new TextBox();
            btnSelectName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Merge Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 37);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Merge File Name:";
            // 
            // txtMergeName
            // 
            txtMergeName.Location = new Point(191, 37);
            txtMergeName.Name = "txtMergeName";
            txtMergeName.Size = new Size(331, 31);
            txtMergeName.TabIndex = 2;
            // 
            // btnSelectName
            // 
            btnSelectName.Location = new Point(545, 37);
            btnSelectName.Name = "btnSelectName";
            btnSelectName.Size = new Size(112, 34);
            btnSelectName.TabIndex = 3;
            btnSelectName.Text = "Select Name";
            btnSelectName.UseVisualStyleBackColor = true;
            // 
            // EditorMergeFiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSelectName);
            Controls.Add(txtMergeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditorMergeFiles";
            Size = new Size(685, 309);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMergeName;
        private Button btnSelectName;
    }
}

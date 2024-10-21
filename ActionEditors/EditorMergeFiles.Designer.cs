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
            label2 = new Label();
            txtMergeName = new TextBox();
            btnSelectName = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Merge File Name:";
            // 
            // txtMergeName
            // 
            txtMergeName.Location = new Point(159, 3);
            txtMergeName.Name = "txtMergeName";
            txtMergeName.Size = new Size(331, 31);
            txtMergeName.TabIndex = 2;
            // 
            // btnSelectName
            // 
            btnSelectName.Location = new Point(496, 3);
            btnSelectName.Name = "btnSelectName";
            btnSelectName.Size = new Size(112, 34);
            btnSelectName.TabIndex = 3;
            btnSelectName.Text = "Select Name";
            btnSelectName.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtMergeName);
            flowLayoutPanel1.Controls.Add(btnSelectName);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(685, 309);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // EditorMergeFiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4);
            Name = "EditorMergeFiles";
            Size = new Size(685, 309);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtMergeName;
        private Button btnSelectName;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

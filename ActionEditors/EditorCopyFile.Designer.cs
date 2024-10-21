namespace CommonForms
{
    partial class EditorCopyFile
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
            txtPath = new TextBox();
            btnBrowse = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Folder Path:";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(114, 3);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(295, 31);
            txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(415, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtPath);
            flowLayoutPanel1.Controls.Add(btnBrowse);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(627, 176);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // EditorCopyFile
            // 
            Controls.Add(flowLayoutPanel1);
            Name = "EditorCopyFile";
            Size = new Size(627, 176);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtPath;
        private Button btnBrowse;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

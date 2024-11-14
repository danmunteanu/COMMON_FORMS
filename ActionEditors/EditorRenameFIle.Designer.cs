namespace CommonForms
{
    partial class EditorRenameFile
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
            txtPrefix = new TextBox();
            txtExtension = new TextBox();
            txtCustom = new TextBox();
            chkAddPrefix = new CheckBox();
            chkExtension = new CheckBox();
            chkCustom = new CheckBox();
            SuspendLayout();
            // 
            // txtPrefix
            // 
            txtPrefix.Location = new Point(35, 47);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(125, 31);
            txtPrefix.TabIndex = 1;
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(226, 47);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(151, 31);
            txtExtension.TabIndex = 3;
            // 
            // txtCustom
            // 
            txtCustom.Location = new Point(35, 168);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(342, 31);
            txtCustom.TabIndex = 4;
            // 
            // chkAddPrefix
            // 
            chkAddPrefix.AutoSize = true;
            chkAddPrefix.Location = new Point(35, 17);
            chkAddPrefix.Name = "chkAddPrefix";
            chkAddPrefix.Size = new Size(124, 29);
            chkAddPrefix.TabIndex = 6;
            chkAddPrefix.Text = "Add Prefix:";
            chkAddPrefix.UseVisualStyleBackColor = true;
            chkAddPrefix.CheckedChanged += chkAddPrefix_CheckedChanged;
            // 
            // chkExtension
            // 
            chkExtension.AutoSize = true;
            chkExtension.Location = new Point(226, 17);
            chkExtension.Name = "chkExtension";
            chkExtension.Size = new Size(182, 29);
            chkExtension.TabIndex = 7;
            chkExtension.Text = "Change Extension:";
            chkExtension.UseVisualStyleBackColor = true;
            chkExtension.CheckedChanged += chkNewExt_CheckedChanged;
            // 
            // chkCustom
            // 
            chkCustom.AutoSize = true;
            chkCustom.Location = new Point(35, 138);
            chkCustom.Name = "chkCustom";
            chkCustom.Size = new Size(156, 29);
            chkCustom.TabIndex = 8;
            chkCustom.Text = "Custom Name:";
            chkCustom.UseVisualStyleBackColor = true;
            chkCustom.CheckedChanged += chkCustom_CheckedChanged;
            // 
            // EditorRenameFile
            // 
            Controls.Add(chkCustom);
            Controls.Add(chkExtension);
            Controls.Add(chkAddPrefix);
            Controls.Add(txtCustom);
            Controls.Add(txtExtension);
            Controls.Add(txtPrefix);
            Name = "EditorRenameFile";
            Size = new Size(483, 268);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrefix;
        private TextBox txtExtension;
        private TextBox txtCustom;
        private CheckBox chkAddPrefix;
        private CheckBox chkExtension;
        private CheckBox chkCustom;
    }
}

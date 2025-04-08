namespace CommonForms
{
    partial class EditorIsFolder
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
            lblMessage = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(27, 83);
            lblMessage.Name = "label1";
            lblMessage.Size = new Size(244, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Evaluates if the selected path is a folder";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Controls.Add(lblMessage, 1, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutPanel1";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(298, 186);
            tableLayoutMain.TabIndex = 1;
            // 
            // EditorIsFolder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "EditorIsFolder";
            Size = new Size(298, 186);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessage;
        private TableLayoutPanel tableLayoutMain;
    }
}

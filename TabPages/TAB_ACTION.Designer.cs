namespace CommonForms.TabPages
{
    partial class TAB_Action
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
            cmbActions = new ComboBox();
            label1 = new Label();
            panelEditor = new Panel();
            btnApply = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutActionRow = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutActionRow.SuspendLayout();
            SuspendLayout();
            // 
            // cmbActions
            // 
            cmbActions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbActions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActions.FormattingEnabled = true;
            cmbActions.Location = new Point(88, 5);
            cmbActions.Name = "cmbActions";
            cmbActions.Size = new Size(179, 28);
            cmbActions.TabIndex = 0;
            cmbActions.SelectedIndexChanged += cmbActions_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Action:";
            // 
            // panelEditor
            // 
            panelEditor.Dock = DockStyle.Fill;
            panelEditor.Location = new Point(23, 73);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(568, 167);
            panelEditor.TabIndex = 2;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnApply.Location = new Point(23, 246);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(568, 38);
            btnApply.TabIndex = 3;
            btnApply.Text = "APPLY";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutActionRow, 1, 1);
            tableLayoutPanel1.Controls.Add(panelEditor, 1, 2);
            tableLayoutPanel1.Controls.Add(btnApply, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(614, 313);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutActionRow
            // 
            tableLayoutActionRow.ColumnCount = 3;
            tableLayoutActionRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutActionRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185F));
            tableLayoutActionRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutActionRow.Controls.Add(label1, 0, 0);
            tableLayoutActionRow.Controls.Add(cmbActions, 1, 0);
            tableLayoutActionRow.Dock = DockStyle.Fill;
            tableLayoutActionRow.Location = new Point(23, 28);
            tableLayoutActionRow.Name = "tableLayoutActionRow";
            tableLayoutActionRow.RowCount = 1;
            tableLayoutActionRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutActionRow.Size = new Size(568, 39);
            tableLayoutActionRow.TabIndex = 5;
            // 
            // TAB_Action
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TAB_Action";
            Size = new Size(614, 313);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutActionRow.ResumeLayout(false);
            tableLayoutActionRow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbActions;
        private Label label1;
        private Panel panelEditor;
        private Button btnApply;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutActionRow;
    }
}

namespace CommonForms.Components
{
    partial class DialogSelectChange
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDesc = new TextBox();
            lblSelAct = new Label();
            cmbAction = new ComboBox();
            lblSelCond = new Label();
            cmbCondition = new ComboBox();
            panelAction = new Panel();
            panelCondition = new Panel();
            tableLayoutButtons = new TableLayoutPanel();
            btnClose = new Button();
            btnSubmit = new Button();
            chkEnabled = new CheckBox();
            lblConditionDesc = new Label();
            lblActionDesc = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanelConditionAction = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanelCond = new TableLayoutPanel();
            tableLayoutChangeDesc = new TableLayoutPanel();
            tableLayoutDesc = new TableLayoutPanel();
            chkDesc = new CheckBox();
            btnResetDesc = new Button();
            tableLayoutEditors = new TableLayoutPanel();
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelConditionAction.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanelCond.SuspendLayout();
            tableLayoutChangeDesc.SuspendLayout();
            tableLayoutDesc.SuspendLayout();
            tableLayoutEditors.SuspendLayout();
            SuspendLayout();
            // 
            // txtDesc
            // 
            txtDesc.Dock = DockStyle.Fill;
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(16, 53);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(853, 96);
            txtDesc.TabIndex = 51;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(4, 12);
            lblSelAct.Margin = new Padding(4, 0, 4, 0);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(75, 25);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Execute:";
            // 
            // cmbAction
            // 
            cmbAction.Dock = DockStyle.Fill;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(4, 42);
            cmbAction.Margin = new Padding(4, 5, 4, 5);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(236, 33);
            cmbAction.TabIndex = 40;
            cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(4, 12);
            lblSelCond.Margin = new Padding(4, 0, 4, 0);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(62, 25);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "When:";
            // 
            // cmbCondition
            // 
            cmbCondition.Dock = DockStyle.Fill;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(4, 42);
            cmbCondition.Margin = new Padding(4, 5, 4, 5);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(236, 33);
            cmbCondition.TabIndex = 39;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(443, 2);
            panelAction.Margin = new Padding(1, 2, 1, 2);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(441, 256);
            panelAction.TabIndex = 42;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(1, 2);
            panelCondition.Margin = new Padding(1, 2, 1, 2);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(440, 256);
            panelCondition.TabIndex = 43;
            // 
            // tableLayoutButtons
            // 
            tableLayoutButtons.ColumnCount = 5;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutButtons.Controls.Add(btnClose, 3, 0);
            tableLayoutButtons.Controls.Add(btnSubmit, 2, 0);
            tableLayoutButtons.Controls.Add(chkEnabled, 1, 0);
            tableLayoutButtons.Dock = DockStyle.Fill;
            tableLayoutButtons.Location = new Point(4, 590);
            tableLayoutButtons.Margin = new Padding(4, 3, 4, 3);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 1;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutButtons.Size = new Size(883, 44);
            tableLayoutButtons.TabIndex = 48;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(721, 2);
            btnClose.Margin = new Padding(1, 2, 1, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 40);
            btnClose.TabIndex = 48;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.Location = new Point(571, 2);
            btnSubmit.Margin = new Padding(1, 2, 1, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(148, 40);
            btnSubmit.TabIndex = 47;
            btnSubmit.Text = "UPDATE";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(16, 7);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(101, 29);
            chkEnabled.TabIndex = 50;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // lblConditionDesc
            // 
            lblConditionDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblConditionDesc.AutoSize = true;
            lblConditionDesc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConditionDesc.Location = new Point(4, 7);
            lblConditionDesc.Margin = new Padding(4, 0, 4, 0);
            lblConditionDesc.Name = "lblConditionDesc";
            lblConditionDesc.Size = new Size(412, 25);
            lblConditionDesc.TabIndex = 49;
            lblConditionDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActionDesc
            // 
            lblActionDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblActionDesc.AutoSize = true;
            lblActionDesc.Location = new Point(423, 7);
            lblActionDesc.Name = "lblActionDesc";
            lblActionDesc.Size = new Size(415, 25);
            lblActionDesc.TabIndex = 50;
            lblActionDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPanelConditionAction, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutChangeDesc, 0, 4);
            tableLayoutMain.Controls.Add(tableLayoutEditors, 0, 3);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 5);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 7;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 168F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutMain.Size = new Size(891, 650);
            tableLayoutMain.TabIndex = 1;
            // 
            // tableLayoutPanelConditionAction
            // 
            tableLayoutPanelConditionAction.ColumnCount = 3;
            tableLayoutPanelConditionAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanelConditionAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelConditionAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelConditionAction.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanelConditionAction.Controls.Add(tableLayoutPanelCond, 1, 0);
            tableLayoutPanelConditionAction.Dock = DockStyle.Fill;
            tableLayoutPanelConditionAction.Location = new Point(4, 18);
            tableLayoutPanelConditionAction.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelConditionAction.Name = "tableLayoutPanelConditionAction";
            tableLayoutPanelConditionAction.RowCount = 1;
            tableLayoutPanelConditionAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelConditionAction.Size = new Size(883, 87);
            tableLayoutPanelConditionAction.TabIndex = 41;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 244F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblSelAct, 0, 0);
            tableLayoutPanel2.Controls.Add(cmbAction, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(452, 3);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new Size(427, 81);
            tableLayoutPanel2.TabIndex = 42;
            // 
            // tableLayoutPanelCond
            // 
            tableLayoutPanelCond.ColumnCount = 2;
            tableLayoutPanelCond.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 244F));
            tableLayoutPanelCond.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCond.Controls.Add(lblSelCond, 0, 0);
            tableLayoutPanelCond.Controls.Add(cmbCondition, 0, 1);
            tableLayoutPanelCond.Dock = DockStyle.Fill;
            tableLayoutPanelCond.Location = new Point(17, 3);
            tableLayoutPanelCond.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelCond.Name = "tableLayoutPanelCond";
            tableLayoutPanelCond.RowCount = 2;
            tableLayoutPanelCond.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanelCond.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanelCond.Size = new Size(427, 81);
            tableLayoutPanelCond.TabIndex = 42;
            // 
            // tableLayoutChangeDesc
            // 
            tableLayoutChangeDesc.ColumnCount = 3;
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutChangeDesc.Controls.Add(tableLayoutDesc, 1, 0);
            tableLayoutChangeDesc.Controls.Add(txtDesc, 1, 1);
            tableLayoutChangeDesc.Dock = DockStyle.Fill;
            tableLayoutChangeDesc.Location = new Point(3, 422);
            tableLayoutChangeDesc.Name = "tableLayoutChangeDesc";
            tableLayoutChangeDesc.RowCount = 3;
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutChangeDesc.Size = new Size(885, 162);
            tableLayoutChangeDesc.TabIndex = 52;
            // 
            // tableLayoutDesc
            // 
            tableLayoutDesc.ColumnCount = 3;
            tableLayoutDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDesc.Controls.Add(chkDesc, 0, 0);
            tableLayoutDesc.Controls.Add(btnResetDesc, 1, 0);
            tableLayoutDesc.Dock = DockStyle.Fill;
            tableLayoutDesc.Location = new Point(17, 3);
            tableLayoutDesc.Margin = new Padding(4, 3, 4, 3);
            tableLayoutDesc.Name = "tableLayoutDesc";
            tableLayoutDesc.RowCount = 1;
            tableLayoutDesc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDesc.Size = new Size(851, 44);
            tableLayoutDesc.TabIndex = 0;
            // 
            // chkDesc
            // 
            chkDesc.Anchor = AnchorStyles.Left;
            chkDesc.AutoSize = true;
            chkDesc.Location = new Point(4, 7);
            chkDesc.Margin = new Padding(4, 3, 4, 3);
            chkDesc.Name = "chkDesc";
            chkDesc.Size = new Size(171, 29);
            chkDesc.TabIndex = 51;
            chkDesc.Text = "Add Description:";
            chkDesc.UseVisualStyleBackColor = true;
            chkDesc.CheckedChanged += chkDesc_CheckedChanged;
            // 
            // btnResetDesc
            // 
            btnResetDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnResetDesc.Font = new Font("Segoe UI", 7F);
            btnResetDesc.Location = new Point(195, 8);
            btnResetDesc.Margin = new Padding(4, 3, 4, 3);
            btnResetDesc.Name = "btnResetDesc";
            btnResetDesc.Size = new Size(73, 27);
            btnResetDesc.TabIndex = 52;
            btnResetDesc.Text = "RESET";
            btnResetDesc.UseVisualStyleBackColor = true;
            btnResetDesc.Click += btnResetDesc_Click;
            // 
            // tableLayoutEditors
            // 
            tableLayoutEditors.ColumnCount = 2;
            tableLayoutEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutEditors.Controls.Add(panelCondition, 0, 0);
            tableLayoutEditors.Controls.Add(panelAction, 1, 0);
            tableLayoutEditors.Dock = DockStyle.Fill;
            tableLayoutEditors.Location = new Point(3, 156);
            tableLayoutEditors.Name = "tableLayoutEditors";
            tableLayoutEditors.RowCount = 1;
            tableLayoutEditors.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutEditors.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutEditors.Size = new Size(885, 260);
            tableLayoutEditors.TabIndex = 0;
            // 
            // DialogSelectChange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 650);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(1, 2, 1, 2);
            MaximizeBox = false;
            Name = "DialogSelectChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SELECT CHANGE";
            tableLayoutButtons.ResumeLayout(false);
            tableLayoutButtons.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanelConditionAction.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanelCond.ResumeLayout(false);
            tableLayoutPanelCond.PerformLayout();
            tableLayoutChangeDesc.ResumeLayout(false);
            tableLayoutChangeDesc.PerformLayout();
            tableLayoutDesc.ResumeLayout(false);
            tableLayoutDesc.PerformLayout();
            tableLayoutEditors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelAction;
        private Panel panelCondition;
        private Label lblSelAct;
        private ComboBox cmbAction;
        private Button btnSubmit;
        private Button btnClose;
        private TableLayoutPanel tableLayoutButtons;
        private Label lblSelCond;
        private ComboBox cmbCondition;
        private Label lblConditionDesc;
        private CheckBox chkEnabled;
        private Label lblActionDesc;
        private TextBox txtDesc;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutEditors;
        private TableLayoutPanel tableLayoutChangeDesc;
        private CheckBox chkDesc;
        private TableLayoutPanel tableLayoutDesc;
        private Button btnResetDesc;
        private TableLayoutPanel tableLayoutPanelConditionAction;
        private TableLayoutPanel tableLayoutPanelCond;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
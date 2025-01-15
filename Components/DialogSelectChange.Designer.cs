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
            tableLayoutChangeDesc = new TableLayoutPanel();
            tableLayoutDesc = new TableLayoutPanel();
            chkDesc = new CheckBox();
            btnResetDesc = new Button();
            tableLayoutEditors = new TableLayoutPanel();
            grpCondition = new GroupBox();
            tableLayoutPanelConditionGroup = new TableLayoutPanel();
            tableLayoutPanelCmbCondition = new TableLayoutPanel();
            grpAction = new GroupBox();
            tableLayoutPanelAction = new TableLayoutPanel();
            tableLayoutPanelCmbAction = new TableLayoutPanel();
            tableLayoutButtons.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutChangeDesc.SuspendLayout();
            tableLayoutDesc.SuspendLayout();
            tableLayoutEditors.SuspendLayout();
            grpCondition.SuspendLayout();
            tableLayoutPanelConditionGroup.SuspendLayout();
            tableLayoutPanelCmbCondition.SuspendLayout();
            grpAction.SuspendLayout();
            tableLayoutPanelAction.SuspendLayout();
            tableLayoutPanelCmbAction.SuspendLayout();
            SuspendLayout();
            // 
            // txtDesc
            // 
            txtDesc.Dock = DockStyle.Fill;
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(12, 42);
            txtDesc.Margin = new Padding(2, 2, 2, 2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(698, 78);
            txtDesc.TabIndex = 51;
            // 
            // lblSelAct
            // 
            lblSelAct.Anchor = AnchorStyles.Right;
            lblSelAct.AutoSize = true;
            lblSelAct.Location = new Point(10, 8);
            lblSelAct.Name = "lblSelAct";
            lblSelAct.Size = new Size(63, 20);
            lblSelAct.TabIndex = 37;
            lblSelAct.Text = "Execute:";
            // 
            // cmbAction
            // 
            cmbAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(79, 4);
            cmbAction.Margin = new Padding(3, 4, 3, 4);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(168, 28);
            cmbAction.TabIndex = 40;
            cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
            // 
            // lblSelCond
            // 
            lblSelCond.Anchor = AnchorStyles.Right;
            lblSelCond.AutoSize = true;
            lblSelCond.Location = new Point(7, 8);
            lblSelCond.Name = "lblSelCond";
            lblSelCond.Size = new Size(50, 20);
            lblSelCond.TabIndex = 36;
            lblSelCond.Text = "When:";
            // 
            // cmbCondition
            // 
            cmbCondition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(63, 4);
            cmbCondition.Margin = new Padding(3, 4, 3, 4);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(187, 28);
            cmbCondition.TabIndex = 39;
            cmbCondition.SelectedIndexChanged += cmbCondition_SelectedIndexChanged;
            // 
            // panelAction
            // 
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(1, 54);
            panelAction.Margin = new Padding(1, 2, 1, 2);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(351, 295);
            panelAction.TabIndex = 42;
            // 
            // panelCondition
            // 
            panelCondition.Dock = DockStyle.Fill;
            panelCondition.Location = new Point(1, 54);
            panelCondition.Margin = new Padding(1, 2, 1, 2);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(351, 295);
            panelCondition.TabIndex = 43;
            // 
            // tableLayoutButtons
            // 
            tableLayoutButtons.ColumnCount = 5;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutButtons.Controls.Add(btnClose, 3, 0);
            tableLayoutButtons.Controls.Add(btnSubmit, 2, 0);
            tableLayoutButtons.Controls.Add(chkEnabled, 1, 0);
            tableLayoutButtons.Dock = DockStyle.Fill;
            tableLayoutButtons.Location = new Point(3, 519);
            tableLayoutButtons.Margin = new Padding(3, 2, 3, 2);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.RowCount = 1;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutButtons.Size = new Size(720, 36);
            tableLayoutButtons.TabIndex = 48;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(591, 2);
            btnClose.Margin = new Padding(1, 2, 1, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 32);
            btnClose.TabIndex = 48;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.Location = new Point(471, 2);
            btnSubmit.Margin = new Padding(1, 2, 1, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 32);
            btnSubmit.TabIndex = 47;
            btnSubmit.Text = "UPDATE";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(12, 6);
            chkEnabled.Margin = new Padding(2, 2, 2, 2);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(85, 24);
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
            tableLayoutMain.Controls.Add(tableLayoutChangeDesc, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutEditors, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutButtons, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2, 2, 2, 2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutMain.Size = new Size(726, 567);
            tableLayoutMain.TabIndex = 1;
            // 
            // tableLayoutChangeDesc
            // 
            tableLayoutChangeDesc.ColumnCount = 3;
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutChangeDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutChangeDesc.Controls.Add(tableLayoutDesc, 1, 0);
            tableLayoutChangeDesc.Controls.Add(txtDesc, 1, 1);
            tableLayoutChangeDesc.Dock = DockStyle.Fill;
            tableLayoutChangeDesc.Location = new Point(2, 385);
            tableLayoutChangeDesc.Margin = new Padding(2, 2, 2, 2);
            tableLayoutChangeDesc.Name = "tableLayoutChangeDesc";
            tableLayoutChangeDesc.RowCount = 3;
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutChangeDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutChangeDesc.Size = new Size(722, 130);
            tableLayoutChangeDesc.TabIndex = 52;
            // 
            // tableLayoutDesc
            // 
            tableLayoutDesc.ColumnCount = 3;
            tableLayoutDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDesc.Controls.Add(chkDesc, 0, 0);
            tableLayoutDesc.Controls.Add(btnResetDesc, 1, 0);
            tableLayoutDesc.Dock = DockStyle.Fill;
            tableLayoutDesc.Location = new Point(13, 2);
            tableLayoutDesc.Margin = new Padding(3, 2, 3, 2);
            tableLayoutDesc.Name = "tableLayoutDesc";
            tableLayoutDesc.RowCount = 1;
            tableLayoutDesc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutDesc.Size = new Size(696, 36);
            tableLayoutDesc.TabIndex = 0;
            // 
            // chkDesc
            // 
            chkDesc.Anchor = AnchorStyles.Left;
            chkDesc.AutoSize = true;
            chkDesc.Location = new Point(3, 6);
            chkDesc.Margin = new Padding(3, 2, 3, 2);
            chkDesc.Name = "chkDesc";
            chkDesc.Size = new Size(142, 24);
            chkDesc.TabIndex = 51;
            chkDesc.Text = "Add Description:";
            chkDesc.UseVisualStyleBackColor = true;
            chkDesc.CheckedChanged += chkDesc_CheckedChanged;
            // 
            // btnResetDesc
            // 
            btnResetDesc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnResetDesc.Font = new Font("Segoe UI", 7F);
            btnResetDesc.Location = new Point(156, 7);
            btnResetDesc.Margin = new Padding(3, 2, 3, 2);
            btnResetDesc.Name = "btnResetDesc";
            btnResetDesc.Size = new Size(131, 22);
            btnResetDesc.TabIndex = 52;
            btnResetDesc.Text = "RESET DESCRIPTION";
            btnResetDesc.UseVisualStyleBackColor = true;
            btnResetDesc.Click += btnResetDesc_Click;
            // 
            // tableLayoutEditors
            // 
            tableLayoutEditors.ColumnCount = 2;
            tableLayoutEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutEditors.Controls.Add(grpCondition, 0, 0);
            tableLayoutEditors.Controls.Add(grpAction, 1, 0);
            tableLayoutEditors.Dock = DockStyle.Fill;
            tableLayoutEditors.Location = new Point(2, 2);
            tableLayoutEditors.Margin = new Padding(2, 2, 2, 2);
            tableLayoutEditors.Name = "tableLayoutEditors";
            tableLayoutEditors.RowCount = 1;
            tableLayoutEditors.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutEditors.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutEditors.Size = new Size(722, 379);
            tableLayoutEditors.TabIndex = 0;
            // 
            // grpCondition
            // 
            grpCondition.Controls.Add(tableLayoutPanelConditionGroup);
            grpCondition.Dock = DockStyle.Fill;
            grpCondition.Location = new Point(2, 2);
            grpCondition.Margin = new Padding(2, 2, 2, 2);
            grpCondition.Name = "grpCondition";
            grpCondition.Padding = new Padding(2, 2, 2, 2);
            grpCondition.Size = new Size(357, 375);
            grpCondition.TabIndex = 2;
            grpCondition.TabStop = false;
            grpCondition.Text = "CONDITION";
            // 
            // tableLayoutPanelConditionGroup
            // 
            tableLayoutPanelConditionGroup.ColumnCount = 1;
            tableLayoutPanelConditionGroup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelConditionGroup.Controls.Add(tableLayoutPanelCmbCondition, 0, 1);
            tableLayoutPanelConditionGroup.Controls.Add(panelCondition, 0, 2);
            tableLayoutPanelConditionGroup.Dock = DockStyle.Fill;
            tableLayoutPanelConditionGroup.Location = new Point(2, 22);
            tableLayoutPanelConditionGroup.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelConditionGroup.Name = "tableLayoutPanelConditionGroup";
            tableLayoutPanelConditionGroup.RowCount = 3;
            tableLayoutPanelConditionGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanelConditionGroup.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelConditionGroup.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelConditionGroup.Size = new Size(353, 351);
            tableLayoutPanelConditionGroup.TabIndex = 45;
            // 
            // tableLayoutPanelCmbCondition
            // 
            tableLayoutPanelCmbCondition.ColumnCount = 3;
            tableLayoutPanelCmbCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelCmbCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanelCmbCondition.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCmbCondition.Controls.Add(lblSelCond, 0, 0);
            tableLayoutPanelCmbCondition.Controls.Add(cmbCondition, 1, 0);
            tableLayoutPanelCmbCondition.Dock = DockStyle.Fill;
            tableLayoutPanelCmbCondition.Location = new Point(2, 14);
            tableLayoutPanelCmbCondition.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelCmbCondition.Name = "tableLayoutPanelCmbCondition";
            tableLayoutPanelCmbCondition.RowCount = 1;
            tableLayoutPanelCmbCondition.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCmbCondition.Size = new Size(349, 36);
            tableLayoutPanelCmbCondition.TabIndex = 44;
            // 
            // grpAction
            // 
            grpAction.Controls.Add(tableLayoutPanelAction);
            grpAction.Dock = DockStyle.Fill;
            grpAction.Location = new Point(363, 2);
            grpAction.Margin = new Padding(2, 2, 2, 2);
            grpAction.Name = "grpAction";
            grpAction.Padding = new Padding(2, 2, 2, 2);
            grpAction.Size = new Size(357, 375);
            grpAction.TabIndex = 43;
            grpAction.TabStop = false;
            grpAction.Text = "ACTION";
            // 
            // tableLayoutPanelAction
            // 
            tableLayoutPanelAction.ColumnCount = 1;
            tableLayoutPanelAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAction.Controls.Add(panelAction, 0, 2);
            tableLayoutPanelAction.Controls.Add(tableLayoutPanelCmbAction, 0, 1);
            tableLayoutPanelAction.Dock = DockStyle.Fill;
            tableLayoutPanelAction.Location = new Point(2, 22);
            tableLayoutPanelAction.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelAction.Name = "tableLayoutPanelAction";
            tableLayoutPanelAction.RowCount = 3;
            tableLayoutPanelAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanelAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAction.Size = new Size(353, 351);
            tableLayoutPanelAction.TabIndex = 44;
            // 
            // tableLayoutPanelCmbAction
            // 
            tableLayoutPanelCmbAction.ColumnCount = 3;
            tableLayoutPanelCmbAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tableLayoutPanelCmbAction.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tableLayoutPanelCmbAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCmbAction.Controls.Add(lblSelAct, 0, 0);
            tableLayoutPanelCmbAction.Controls.Add(cmbAction, 1, 0);
            tableLayoutPanelCmbAction.Dock = DockStyle.Fill;
            tableLayoutPanelCmbAction.Location = new Point(2, 14);
            tableLayoutPanelCmbAction.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanelCmbAction.Name = "tableLayoutPanelCmbAction";
            tableLayoutPanelCmbAction.RowCount = 1;
            tableLayoutPanelCmbAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCmbAction.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelCmbAction.Size = new Size(349, 36);
            tableLayoutPanelCmbAction.TabIndex = 45;
            // 
            // DialogSelectChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 567);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(1, 2, 1, 2);
            MaximizeBox = false;
            Name = "DialogSelectChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SELECT CHANGE";
            tableLayoutButtons.ResumeLayout(false);
            tableLayoutButtons.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutChangeDesc.ResumeLayout(false);
            tableLayoutChangeDesc.PerformLayout();
            tableLayoutDesc.ResumeLayout(false);
            tableLayoutDesc.PerformLayout();
            tableLayoutEditors.ResumeLayout(false);
            grpCondition.ResumeLayout(false);
            tableLayoutPanelConditionGroup.ResumeLayout(false);
            tableLayoutPanelCmbCondition.ResumeLayout(false);
            tableLayoutPanelCmbCondition.PerformLayout();
            grpAction.ResumeLayout(false);
            tableLayoutPanelAction.ResumeLayout(false);
            tableLayoutPanelCmbAction.ResumeLayout(false);
            tableLayoutPanelCmbAction.PerformLayout();
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
        private GroupBox grpCondition;
        private GroupBox grpAction;
        private TableLayoutPanel tableLayoutPanelCmbCondition;
        private TableLayoutPanel tableLayoutPanelConditionGroup;
        private TableLayoutPanel tableLayoutPanelAction;
        private TableLayoutPanel tableLayoutPanelCmbAction;
    }
}
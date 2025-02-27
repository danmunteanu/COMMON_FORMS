namespace CommonForms
{
    partial class EditorActionGroup
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel = new TableLayoutPanel();
            btnNext = new Button();
            lblCountActions = new Label();
            btnPrev = new Button();
            lblActionName = new Label();
            btnDel = new Button();
            btnAdd = new Button();
            panelActiveAction = new Panel();
            menuStripActions = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(panelActiveAction, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Size = new Size(622, 370);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 9;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(btnNext, 5, 0);
            tableLayoutPanel.Controls.Add(lblCountActions, 4, 0);
            tableLayoutPanel.Controls.Add(btnPrev, 3, 0);
            tableLayoutPanel.Controls.Add(lblActionName, 2, 0);
            tableLayoutPanel.Controls.Add(btnDel, 1, 0);
            tableLayoutPanel.Controls.Add(btnAdd, 7, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(8, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(606, 39);
            tableLayoutPanel.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNext.Location = new Point(411, 4);
            btnNext.MinimumSize = new Size(0, 30);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(39, 30);
            btnNext.TabIndex = 1;
            btnNext.Text = "▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblCountActions
            // 
            lblCountActions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCountActions.AutoSize = true;
            lblCountActions.Location = new Point(366, 9);
            lblCountActions.Name = "lblCountActions";
            lblCountActions.Size = new Size(39, 20);
            lblCountActions.TabIndex = 2;
            lblCountActions.Text = "0/0";
            lblCountActions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPrev.Location = new Point(321, 4);
            btnPrev.MinimumSize = new Size(0, 30);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(39, 30);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblActionName
            // 
            lblActionName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblActionName.AutoSize = true;
            lblActionName.Location = new Point(156, 9);
            lblActionName.Name = "lblActionName";
            lblActionName.Size = new Size(159, 20);
            lblActionName.TabIndex = 4;
            lblActionName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDel.Location = new Point(101, 5);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(49, 29);
            btnDel.TabIndex = 5;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(466, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "➕";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelActiveAction
            // 
            panelActiveAction.Dock = DockStyle.Fill;
            panelActiveAction.Location = new Point(8, 48);
            panelActiveAction.Name = "panelActiveAction";
            panelActiveAction.Size = new Size(606, 314);
            panelActiveAction.TabIndex = 2;
            // 
            // menuStripActions
            // 
            menuStripActions.ImageScalingSize = new Size(20, 20);
            menuStripActions.Name = "menuStripActions";
            menuStripActions.Size = new Size(61, 4);
            // 
            // EditorActionGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EditorActionGroup";
            Size = new Size(622, 370);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPrev;
        private TableLayoutPanel tableLayoutPanel;
        private Button btnNext;
        private Label lblCountActions;
        private Panel panelActiveAction;
        private Label lblActionName;
        private Button btnDel;
        private Button btnAdd;
        private ContextMenuStrip menuStripActions;
    }
}

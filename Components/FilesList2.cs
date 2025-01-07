using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonForms.Components
{
    public partial class FilesList2 : UserControl
    {
        public FilesList2()
        {
            InitializeComponent();
            CreateMasterLayout();
        }

        private void FilesList2_Load(object sender, EventArgs e)
        {
            RebuildList();
        }

        public void RebuildList()
        {
            Controls.Clear();
            CreateMasterLayout();
        }

        private TableLayoutPanel CreateTopLine()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.RowCount = 1;

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Label
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // Empty space
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));  // Button 1 (fixed width)
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));  // Button 2 (fixed width)

            Label label = new Label();
            label.Text = "Label:";
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Padding = new Padding(10, 0, 0, 0);
            label.Font = new Font(label.Font.FontFamily, 8);
            label.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            Button button1 = new Button();
            button1.Text = "SELECT ALL";
            button1.Font = new Font(button1.Font.FontFamily, 8);
            button1.AutoSize = true;
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Anchor = AnchorStyles.Right;

            Button button2 = new Button();
            button2.Text = "LIST SETTINGS";
            button2.Font = new Font(button2.Font.FontFamily, 8);
            button2.AutoSize = true;
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Anchor = AnchorStyles.Right;

            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.Controls.Add(button1, 2, 0);
            tableLayoutPanel.Controls.Add(button2, 3, 0);

            return tableLayoutPanel;
        }

        private ListBox CreateListBox()
        {
            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.SelectionMode = SelectionMode.MultiExtended;
            listBox.Font = new Font("Arial", 10);

            listBox.Items.Add("Item 1");
            listBox.Items.Add("Item 2");
            listBox.Items.Add("Item 3");
            listBox.Items.Add("Item 4");

            return listBox;
        }

        private Label CreateStatus()
        {
            Label lblStatus = new Label();
            lblStatus.Text = "Status:";
            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 8);
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            return lblStatus;
        }

        private ProgressBar CreateProgressBar()
        {
            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.Fill;

            return progressBar;
        }

        private TableLayoutPanel CreateBottomLayout()
        {
            TableLayoutPanel buttonTableLayout = new TableLayoutPanel();
            buttonTableLayout.Dock = DockStyle.Fill;
            buttonTableLayout.ColumnCount = 5;
            buttonTableLayout.RowCount = 1;

            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnAdd
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));  // btnReload (square)
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));  // btnRem (square)
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));  // Empty space
            buttonTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // btnClear

            Button btnAdd = new Button();
            btnAdd.Text = "ADD";
            btnAdd.Font = new Font(btnAdd.Font.FontFamily, 8);
            btnAdd.AutoSize = true;
            btnAdd.Anchor = AnchorStyles.Left;

            Button btnReload = new Button();
            btnReload.Text = "↻";
            btnReload.Font = new Font(btnReload.Font.FontFamily, 8);
            btnReload.Size = new Size(25, 25);
            btnReload.Anchor = AnchorStyles.Left;

            Button btnRem = new Button();
            btnRem.Text = "-";
            btnRem.Font = new Font(btnRem.Font.FontFamily, 8);
            btnRem.Size = new Size(25, 25);
            btnRem.Anchor = AnchorStyles.Left;

            Button btnClear = new Button();
            btnClear.Text = "CLEAR";
            btnClear.Font = new Font(btnClear.Font.FontFamily, 8);
            btnClear.AutoSize = true;
            btnClear.Anchor = AnchorStyles.Left;

            buttonTableLayout.Controls.Add(btnAdd, 0, 0);
            buttonTableLayout.Controls.Add(btnReload, 1, 0);
            buttonTableLayout.Controls.Add(btnRem, 2, 0);
            buttonTableLayout.Controls.Add(btnClear, 4, 0);

            return buttonTableLayout;
        }

        private void CreateMasterLayout()
        {
            TableLayoutPanel masterTableLayout = new TableLayoutPanel();
            masterTableLayout.Dock = DockStyle.Fill;
            masterTableLayout.ColumnCount = 1;
            masterTableLayout.RowCount = 5;

            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            masterTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

            TableLayoutPanel topLineLayout = CreateTopLine();
            ListBox listBox = CreateListBox();
            Label statusLabel = CreateStatus();
            ProgressBar progressBar = CreateProgressBar();
            TableLayoutPanel buttonLayout = CreateBottomLayout();

            topLineLayout.Dock = DockStyle.Fill;
            listBox.Dock = DockStyle.Fill;
            statusLabel.Dock = DockStyle.Fill;
            buttonLayout.Dock = DockStyle.Fill;

            masterTableLayout.Controls.Add(topLineLayout, 0, 0);
            masterTableLayout.Controls.Add(listBox, 0, 1);
            masterTableLayout.Controls.Add(statusLabel, 0, 2);
            masterTableLayout.Controls.Add(progressBar, 0, 3);
            masterTableLayout.Controls.Add(buttonLayout, 0, 4);

            this.Controls.Add(masterTableLayout);
        }
    }
}

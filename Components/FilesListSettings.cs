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
    public partial class FilesListSettings : UserControl
    {
        FilesListControl? _listControl = null;

        public FilesListControl? ListControl
        {
            get { return _listControl; }
            set { _listControl = value; OnListControlSet(); }
        }

        public FilesListSettings(FilesListControl listControl)
        {
            InitializeComponent();

            //  use the setter to trigger OnListControlSet
            ListControl = listControl;
        }

        private void OnListControlSet()
        {
            if (_listControl != null)
            {
                chkAddFolders.Checked = _listControl.AddFolders;
                chkParseSubfolders.Enabled = chkAddFolders.Checked;
                chkParseSubfolders.Checked = _listControl.ParseSubfolders;
            }
        }

        private void chkAddFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (_listControl != null)
                _listControl.AddFolders = chkAddFolders.Checked;

            chkParseSubfolders.Enabled = chkAddFolders.Checked;
        }

        private void chkParseSubfolders_CheckedChanged(object sender, EventArgs e)
        {
            if (_listControl != null)
                _listControl.ParseSubfolders = chkParseSubfolders.Checked;
        }
    }
}

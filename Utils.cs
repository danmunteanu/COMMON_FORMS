using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonForms
{
    public class Utils
    {
        //	Helper to add user controls to a panel - should be common somewhere
        public static void AddUserControl(Panel panel, UserControl control)
        {
            if (panel.Controls.Contains(control))
                return;

            control.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.BringToFront();
        }

        //  load action names' list
        public static List<string> GetConditionIDs()
        {
            List<string> ids = new();

            

            return ids;
        }


        //  load condition names' list


    }
}

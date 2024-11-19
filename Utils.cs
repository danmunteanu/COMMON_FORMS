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

        /*
         *  Does a string start with a date prefix?
         *      e.g. 2024-02-01
         */
        public static bool HasDatePrefix(string s)
        {
            //  Try cast first 10 characters to a date 2024-02-01
            if (s.Length > 11)
            {
                //  first 10 characters should be castable to a date
                string titleDate = s.Substring(0, 10);

                //  try to cast to a date
                try
                {
                    DateTime dateCast = DateTime.Parse(titleDate);
                }
                catch (FormatException formatExcept)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}

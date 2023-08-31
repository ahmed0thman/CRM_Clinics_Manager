using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace ClinicManager
{
    public static class WidgetCleaner
    {
        public static void ClearControls(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                try
                {
                    if (control is GunaTextBox c) c.Text = "";
                    else if (control is GunaDateTimePicker c2) c2.ResetText();
                    else if (control is GunaComboBox c3) c3.SelectedIndex = 0;
                    else if (control is GunaDataGridView c4) c4.Rows.Clear();
                }
                catch (Exception)
                {

                    
                }
                
            }
        }

        public static void ClearControls(params GroupBox[] groupBoxs)
        {
            foreach (GroupBox groupBox in groupBoxs)
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is GunaTextBox c) c.Text = "";
                    else if (control is GunaDateTimePicker c2) c2.ResetText();
                    else if (control is GunaComboBox c3) c3.SelectedIndex = 0;
                    else if (control is GunaDataGridView c4) c4.Rows.Clear();
                }
            }
        }
    }
}

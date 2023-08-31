using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClinicManager.UserControls
{
    public partial class UC_DashBoard : UserControl
    {
        public UC_DashBoard()
        {
            InitializeComponent();
        }

        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            ShowUC_Queue();
        }

        private void ShowUC_Queue()
        {
            panelParent.Controls.Clear();
            panelParent.Controls.Add(new UC_QueueCard());
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.BL;

namespace ClinicManager.UserControls
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
            WidgetCleaner.ClearControls(panel1);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUser();
            WidgetCleaner.ClearControls(panel1);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
            WidgetCleaner.ClearControls(panel1);
        }

        private void UC_User_Load(object sender, EventArgs e)
        {
            ShowAllDateInDgvPersons();
        }

        private void dgvPersons_SelectionChanged(object sender, EventArgs e)
        {
            DgvSelectionChanged();
        }
    }
}

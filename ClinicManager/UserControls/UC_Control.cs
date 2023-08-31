using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace ClinicManager.UserControls
{
   
    public partial class UC_Control : UserControl
    {
        #region UserControls Objects Intialization
        // UC_Clinic UC_Clinic = new UC_Clinic();
        UC_User UC_User = new UC_User();
        #endregion

        public UC_Control()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnUsers.Image = Image.FromFile(@"ICO\icons8_add_user_male_100px.png");
            //btnClinics.Image = Image.FromFile(@"ICO\icons8_pill_100px.png");
            panelControlsContainer.Controls.Clear();
            panelControlsContainer.Controls.Add(UC_User);
        }

      
        private void btnMedical_Click_1(object sender, EventArgs e)
        {
            btnMedical.Image = Image.FromFile(@"ICO\icons8_doctors_bag_dark_32.png");
            // btnClinics.Image = Image.FromFile(@"ICO\icons8_pill_100px_1.png");
            panelControlsContainer.Controls.Clear();
            panelControlsContainer.Controls.Add(new UC_Medical());
        }
    }
}

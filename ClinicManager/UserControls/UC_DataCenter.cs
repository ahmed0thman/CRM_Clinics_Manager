using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManager.UserControls
{
    public partial class UC_DataCenter : UserControl
    {
        #region User Controls Objects Intiallization
        UC_Patient UC_Patient = new UC_Patient();
        UC_ReservationSchedule UC_ReservationSchedule = new UC_ReservationSchedule();
        #endregion
        public UC_DataCenter()
        {
            InitializeComponent();
        }

        private void btnPanelPatientInfo_Click(object sender, EventArgs e)
        {
            btnPanelPatientInfo.Image = Image.FromFile(@"ICO\icons8_plus_100px.png");
            btnPanelDashboard.Image = Image.FromFile(@"ICO\icons8_leaving_queue_50px_3.png");
            btnPanelPatient.Image = Image.FromFile(@"ICO\icons8_user_groups_50px.png");
            btnRservationSchedule.Image = Image.FromFile(@"ICO\icons8_schedule_50px.png");
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_Patient);
        }

        private void btnPanelDashboard_Click(object sender, EventArgs e)
        {
            btnPanelPatientInfo.Image = Image.FromFile(@"ICO\icons8_plus_100px_2.png");
            btnPanelDashboard.Image = Image.FromFile(@"ICO\icons8_leaving_queue_50px_2.png");
            btnPanelPatient.Image = Image.FromFile(@"ICO\icons8_user_groups_50px.png");
            btnRservationSchedule.Image = Image.FromFile(@"ICO\icons8_schedule_50px.png");
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UC_DashBoard());
        }

        private void btnPanelPatient_Click(object sender, EventArgs e)
        {
            btnPanelPatientInfo.Image = Image.FromFile(@"ICO\icons8_plus_100px_2.png");
            btnPanelDashboard.Image = Image.FromFile(@"ICO\icons8_leaving_queue_50px_3.png");
            btnPanelPatient.Image = Image.FromFile(@"ICO\icons8_user_groups_50px_1.png");
            btnRservationSchedule.Image = Image.FromFile(@"ICO\icons8_schedule_50px.png");
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UC_PatientsArchieve());
        }

        private void btnRservationSchedule_Click(object sender, EventArgs e)
        {
            btnPanelPatientInfo.Image = Image.FromFile(@"ICO\icons8_plus_100px_2.png");
            btnPanelDashboard.Image = Image.FromFile(@"ICO\icons8_leaving_queue_50px_3.png");
            btnPanelPatient.Image = Image.FromFile(@"ICO\icons8_user_groups_50px.png");
            btnRservationSchedule.Image = Image.FromFile(@"ICO\icons8_schedule_50px_2.png");
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_ReservationSchedule);
        }
    }
}

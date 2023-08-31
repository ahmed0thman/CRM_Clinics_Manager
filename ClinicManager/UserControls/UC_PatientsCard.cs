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
    public partial class UC_PatientsCard : UserControl
    {
        public Patient patientInCard;
        public delegate void clickPatientCard(Patient patient);
        public static event clickPatientCard patientCardClicked;
        public delegate void clickCard(UC_PatientsCard patientCard);
        public static event clickCard cardClicked;
        public UC_PatientsCard(Patient patient)
        {
            InitializeComponent();
            this.patientInCard = patient;
            lblPatientName.Text = patient.patientName;
            lblPatientID.Text = patient.patientID.ToString();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            FireCardClickedEvent();
        }

        public void FireCardClickedEvent()
        {
            patientCardClicked?.Invoke(patientInCard);
            cardClicked.Invoke(this);
        }

        private void lblPatientName_Click(object sender, EventArgs e)
        {
            FireCardClickedEvent();
        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {
            FireCardClickedEvent();
        }

        private void gunaShadowPanel1_Click(object sender, EventArgs e)
        {
            FireCardClickedEvent();
        }
    }
}

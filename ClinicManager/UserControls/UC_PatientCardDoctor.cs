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
    public partial class UC_PatientCardDoctor : UserControl
    {
        public delegate void ClickPatientDone();
        public static event ClickPatientDone PatientDoneClicked;
        public Reservation reservationInCard { get; set; }
        public delegate void clickPatientDoctorCard(Patient patient);
        public static event clickPatientDoctorCard patientDoctorCardClicked;
        int ActualQueue;

        public UC_PatientCardDoctor(Reservation reservationInCard, int actualQueue)
        {
            InitializeComponent();
            ActualQueue = actualQueue;
            lblPatientName.Text = reservationInCard.patient.patientName;
            this.reservationInCard = reservationInCard;
            if (ActualQueue == 1)
            {
                gunaShadowPanel1.BaseColor = Color.FromArgb(161, 216, 211);
                lblQueue.ForeColor = Color.Green;
                lblQueue.Text = "Current";
            }
            else if (ActualQueue == 2)
            {
                gunaShadowPanel1.BaseColor = Color.FromArgb(205, 205, 154);
                lblQueue.ForeColor = Color.Olive;
                lblQueue.Text = "Next";
                btnPatientDone.Hide();
            }
            else
            {
                lblQueue.Text = ActualQueue.ToString();
                btnPatientDone.Hide();
            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e) => FirepatientDoctorCardClicked();

        private void lblPatientName_Click(object sender, EventArgs e) => FirepatientDoctorCardClicked();

        private void gunaShadowPanel1_Click(object sender, EventArgs e) => FirepatientDoctorCardClicked();

        public void FirepatientDoctorCardClicked()
        {
            if (ActualQueue != 1) return;
            Patient patient = new PatientRepository().RetriveOnePatient(reservationInCard.patient.patientID);
            patientDoctorCardClicked.Invoke(patient);

        }

        private void btnPatientDone_Click(object sender, EventArgs e)
        {
            ReservationRepository reservationRepository = new ReservationRepository();
            reservationRepository.DeleteReservation(reservationInCard);
            PatientDoneClicked.Invoke();
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {
            FirepatientDoctorCardClicked();
        }
    }
}

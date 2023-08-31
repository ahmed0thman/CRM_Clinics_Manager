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
    public partial class UC_PatientCardSecretary : UserControl
    {
        public delegate void ClickPatientDone();
        public static event ClickPatientDone PatientDoneClicked;
        Reservation reservationInCard;
        int reservationCount;
        int ActualQueue;
        public UC_PatientCardSecretary(Reservation reservation, int actualQueue, int resCount)
        {
            InitializeComponent();
            panelSwitchReservations.Hide();
            reservationInCard = reservation;
            reservationCount = resCount;
            ActualQueue = actualQueue;
            lblPatientName.Text = reservation.patient.patientName;
            if (ActualQueue == 1)
            {
                gunaShadowPanel1.BaseColor = Color.FromArgb(161, 216, 211);
                lblQueue.ForeColor = Color.Green;
                lblQueue.Text = "Current";
                //btnHold.Hide();
                //btnSwitchQueue.Hide();
            }
            else if (ActualQueue == 2)
            {
                gunaShadowPanel1.BaseColor = Color.FromArgb(205, 205, 154);
                lblQueue.ForeColor = Color.Olive;
                lblQueue.Text = "Next";
                btnPatientDone.Hide();
            }
            else if(ActualQueue < 0)
            {
                lblQueue.ForeColor = Color.Red;
                lblQueue.Text = "Absent";
                btnPatientDone.Hide();
                btnSwitchQueue.Hide();
                btnHold.Image = Image.FromFile(@"ICO\play.png");
                btnHold.OnHoverImage = Image.FromFile(@"ICO\play1.png");
            }
            else
            {
                lblQueue.Text = ActualQueue.ToString();
                btnPatientDone.Hide();
            }
        }

        private void btnPatientDone_Click(object sender, EventArgs e)
        {
            ReservationRepository reservationRepository = new ReservationRepository();
            reservationRepository.DeleteReservation(reservationInCard);
            PatientDoneClicked.Invoke();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            ReservationRepository reservationRepository = new ReservationRepository();
            reservationRepository.HoldReservation(reservationInCard);
            PatientDoneClicked.Invoke();
        }

        private void btnSwitchReservations_Click(object sender, EventArgs e)
        {
            int queueToSwitch = int.Parse(txtQueueSwitch.Text);
            if (queueToSwitch == ActualQueue)
            { 
                MessageBox.Show("patient can't be switched with him/her self");
            }
            else if (queueToSwitch > 0 && queueToSwitch <= reservationCount)
            {
                string dt = DateTime.Now.ToString("yyyy-MM-dd");
                ReservationRepository reservationRepository = new ReservationRepository();
                reservationRepository.SwitchReservations(reservationInCard, UC_QueueCard.reservations[queueToSwitch - 1], dt);
                PatientDoneClicked.Invoke();
            }
            
            else
            {
                MessageBox.Show("Enter A vaild Number");
            }
        }

        private void btnSwitchQueue_Click(object sender, EventArgs e)
        {
            if(!panelSwitchReservations.Visible)
            panelSwitchReservations.Show();
            else
                panelSwitchReservations.Hide();
        }
    }
}

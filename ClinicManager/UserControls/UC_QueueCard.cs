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
    public partial class UC_QueueCard : UserControl
    {
        public static List<Reservation> reservations;
        public UC_QueueCard()
        {
            InitializeComponent();
            UC_PatientCardSecretary.PatientDoneClicked += UC_PatientCardSecretary_PatientDoneClicked;
        }

        private void UC_PatientCardSecretary_PatientDoneClicked()
        {
            GetAllReservation(DateTime.Now);
        }

        private void UC_QueueCard_Load(object sender, EventArgs e)
        {
            GetAllReservation(DateTime.Now);
        }
        private void GetAllReservation(DateTime date)
        {
            ReservationRepository reservationRepository = new ReservationRepository();
            reservations = reservationRepository.RetriveAllReservations(date.ToString("yyyy-MM-dd"), false);
            List<Reservation> holdedReservations = reservationRepository.RetriveAllReservations(date.ToString("yyyy-MM-dd"), true);
            panelQueue.Controls.Clear();
            int queue = 1;
            int resCount = reservations.Count;
            foreach (Reservation reservation in reservations)
            {
                panelQueue.Controls.Add(new UC_PatientCardSecretary(reservation, queue, resCount));
                queue += 1;
            }
            foreach (Reservation reservation in holdedReservations)
            {
                panelQueue.Controls.Add(new UC_PatientCardSecretary(reservation, reservation.reservationQueue, resCount));
            }
        }
    }
}

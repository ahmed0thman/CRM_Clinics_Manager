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
    public partial class UC_ReservationSchedule : UserControl
    {
        public UC_ReservationSchedule()
        {
            InitializeComponent();
            dt.MinDate = DateTime.Now;
        }

        private void UC_ReservationSchedule_Load(object sender, EventArgs e)
        {
            GetFollowsUps();
            GetReservations();
        }

        private void GetFollowsUps()
        {
            CheckUpRepository checkUpRepository = new CheckUpRepository();
            DataTable tblCheckUps = checkUpRepository.RetriveAllCheckUps(dt.Value.ToString("yyyy-MM-dd"));
            dgvFollowUps.DataSource = tblCheckUps;
        }

        private void GetReservations()
        {
            ReservationRepository reservationRepository = new ReservationRepository();
            DataTable tblReservations = reservationRepository.RetriveAllReservations(dt.Value.ToString("yyyy-MM-dd"));
            dgvReservations.DataSource = tblReservations;
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            GetFollowsUps();
            GetReservations();
        }
    }
}

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
    public partial class UC_PatientsArchieve : UserControl
    {
        
        List<Patient> patients = new List<Patient>();
        List<UC_PatientsCard> uC_PatientsCards = new List<UC_PatientsCard>();
        Patient currentPatient;
        UC_PatientsCard currentCard;
        DataTable CurrentPatientTreatment;
        public UC_PatientsArchieve()
        {
            InitializeComponent();
            UC_PatientsCard.patientCardClicked += UC_PatientsCard_patientCardClicked;
            UC_PatientSec.patientInfoSaved += UC_PatientSec_patientInfoSaved;
            UC_PatientsCard.cardClicked += UC_PatientsCard_cardClicked;
        }

        private void UC_PatientsCard_cardClicked(UC_PatientsCard patientCard)
        {
            if (currentCard != null)
                currentCard.gunaShadowPanel1.BaseColor = Color.White;
            currentCard = patientCard;
            currentCard.gunaShadowPanel1.BaseColor = Color.FromArgb(161, 216, 211);
        }

        private void UC_PatientSec_patientInfoSaved(Patient patient)
        {
            GetAllPatients();
            UC_PatientsCard card = uC_PatientsCards.Find(x => x.patientInCard.patientID == patient.patientID);
            card.FireCardClickedEvent();
            trans2.HideSync(panelPatientInfo);
        }

        private void UC_PatientsCard_patientCardClicked(Patient patient)
        {
           
            panelPatientInfo.Controls.Clear();
            ShowPatientInfo(patient);
        }

        

        private void UC_PatientsArchieve_Load(object sender, EventArgs e)
        {
            panelPatientInfo.BringToFront();
            panelReservation.Hide();
            panelPatientInfo.Hide();
            GetAllPatients();

        }

        private void btnPanelReservation_Click(object sender, EventArgs e)
        {
            if(!panelReservation.Visible)
            trans2.ShowSync(panelReservation);
            else
            trans2.HideSync(panelReservation);
        }

        private void btnSaveReservation_Click(object sender, EventArgs e)
        {
            SaveReservation();
        }

        private void btnSavePatientInfo_Click(object sender, EventArgs e)
        {
            trans2.HideSync(panelPatientInfo);
        }

        private void btnShowPanelInfo_Click(object sender, EventArgs e)
        {
            if (currentPatient == null)
            {
                MessageBox.Show("Choose valid patient");
                return;
            }
            panelPatientInfo.Controls.Clear();
            if (!panelPatientInfo.Visible)
                trans2.ShowSync(panelPatientInfo);
            else
            {
                trans2.HideSync(panelPatientInfo);
                return;
            }
            panelPatientInfo.Controls.Add(new UC_PatientSec(currentPatient, CurrentPatientTreatment));

        }

       
        private void txtPatientSearch_TextChanged(object sender, EventArgs e)
        {
            GetPatientsByIDOrPhone();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not allowed to delete patients");
        }



        #region Functions In Partial Class
        private void GetAllPatients()
        {
            PatientRepository patientRepository = new PatientRepository();
            try
            {
                patients = patientRepository.RetriveAllPatients();
                panelPatientsCards.Controls.Clear();
                uC_PatientsCards.Clear();
                foreach (Patient patient in patients)
                {
                    UC_PatientsCard uC_PatientsCard = new UC_PatientsCard(patient);
                    uC_PatientsCards.Add(uC_PatientsCard);
                    panelPatientsCards.Controls.Add(uC_PatientsCard);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetPatientsByIDOrPhone()
        {
            IEnumerable<UC_PatientsCard> specficPatients;
            if (txtPatientSearch.Text == "") return;
            if (txtPatientSearch.Text[0] == '0')
            {
                specficPatients = from p in this.uC_PatientsCards
                                  where p.patientInCard.PatientPhone.ToString().Contains(txtPatientSearch.Text)
                                  select p;
            }
            else
            {
                specficPatients = from p in this.uC_PatientsCards
                                  where p.patientInCard.patientID.ToString().Contains(txtPatientSearch.Text)
                                  select p;
            }

            panelPatientsCards.Controls.Clear();
            foreach (UC_PatientsCard uC_PatientsCard in specficPatients)
            {
                panelPatientsCards.Controls.Add(uC_PatientsCard);
            }
        }

        private void ShowPatientInfo(Patient patient)
        {
            currentPatient = patient;
            lblName.Text = patient.patientName;
            lblAge.Text = "Age: " + patient.patientAge.ToString();
            lblAddress.Text = patient.PatientAddress;
            lblPhone.Text = patient.PatientPhone;
            lblDtBirth.Text = patient.patientBirthDate;
            lblGovernment.Text = patient.patientGovernment;
            lblNationalId.Text = patient.patientNationalID;
            lblHistoricalDisease.Text = patient.patientHistoricalDisease;
            lblSufferFrom.Text = patient.patientSufferFrom;
            CurrentPatientTreatment = new PatientTreatmentRepository().RetriveOnePatientTreatments(currentPatient.patientID);
            dgvPatientsTreatments.DataSource = CurrentPatientTreatment;
        }

        private void SaveReservation()
        {
            if (currentPatient == null)
            {
                MessageBox.Show("Choose valid patient");
                return;
            }
            ReservationRepository reservationRepository = new ReservationRepository();
            bool vaild = reservationRepository.RetriveOneReservation(currentPatient.patientID);
            int lastQueue = reservationRepository.GetLastQueueInDate(dtReservation.Value.ToString("yyyy-MM-dd"));
            int countReservations = reservationRepository.CountReservations(dtReservation.Value.ToString("yyyy-MM-dd"));
            if (lastQueue == -1) lastQueue = 0;
            if (countReservations == -1) countReservations = 0;
            if (!vaild)
            {
                DialogResult msg = MessageBox.Show("Patient already reserved, Want to update?", "", MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                    return;
                else if (msg == DialogResult.Yes)
                {
                    reservationRepository.updateReservation(new Reservation(currentPatient, dtReservation.Value.ToString("yyyy-MM-dd"), lastQueue + 1));
                }
            }
            else
                reservationRepository.AddReservation(new Reservation(currentPatient, dtReservation.Value.ToString("yyyy-MM-dd"), lastQueue + 1));
            trans2.HideSync(panelReservation);
            MessageBox.Show($"Reservation was saved, patients Queue is {countReservations + 1}");
        }
        #endregion

    }
}

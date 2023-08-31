using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;
using Guna.UI.WinForms;
using Guna.UI.Lib.ScrollBar;
using Clinic.BL;

namespace ClinicManager.UserControls
{
    public partial class UC_Doctor : UserControl
    {

        Dictionary<string, string> dictTreatments = new Dictionary<string, string>();
        AutoCompleteStringCollection treatmentsCollection = new AutoCompleteStringCollection();

        Dictionary<string, string> dictAnalysis = new Dictionary<string, string>();
        AutoCompleteStringCollection AnalysisCollection = new AutoCompleteStringCollection();

        Dictionary<string, string> dictRays = new Dictionary<string, string>();
        AutoCompleteStringCollection RaysCollection = new AutoCompleteStringCollection();

        List<Reservation> reservations = new List<Reservation>();
        List<UC_PatientCardDoctor> uC_PatientsCards = new List<UC_PatientCardDoctor>();
        Patient currentPatient;
        DataTable CurrentPatientTreatment;
        public UC_Doctor()
        {
            InitializeComponent();
            dtpReservations.MinDate = DateTime.Now;
            dtpDiagnosisDate.MinDate = DateTime.Now;
            dtpCheckUpDate.MinDate = DateTime.Now;
            GetCollectionsElements();
            UC_PatientCardDoctor.patientDoctorCardClicked += UC_PatientCardDoctor_patientDoctorCardClicked;
            UC_PatientSec.patientInfoSaved += UC_PatientSec_patientInfoSaved;
            UC_PatientCardDoctor.PatientDoneClicked += UC_PatientCardDoctor_PatientDoneClicked;
        }


        private void GetCollectionsElements()
        {
            //Ray>>>
            List<Ray> rays = new RayRepository().RetriveAllRay();
            foreach (Ray ray in rays)
            {
                dictRays.Add(ray.rayID.ToString(), ray.rayName);
                RaysCollection.Add(ray.rayName);
            }

            //ANAL>>>>
            List<Analysis> anals = new AnalysisRepository().RetriveAllAnalysises();
            foreach (Analysis anal in anals)
            {
                dictAnalysis.Add(anal.analysisID.ToString(), anal.analysisName);
                AnalysisCollection.Add(anal.analysisName);
            }
            //Treatment>>>>
            List<Treatment> treats = new TreatmentRepository().RetriveAllTreatment();
            foreach (Treatment treat in treats)
            {
                dictTreatments.Add(treat.TreatmentID.ToString(), treat.TreatmentName);
                treatmentsCollection.Add(treat.TreatmentName);
            }

        }

        private void UC_PatientCardDoctor_PatientDoneClicked()
        {
            GetAllResevations();
        }

        private void UC_PatientSec_patientInfoSaved(Patient patient)
        {
            GetAllResevations();
            UC_PatientCardDoctor card = uC_PatientsCards.Find(x => x.reservationInCard.patient.patientID == patient.patientID);
            card.FirepatientDoctorCardClicked();
            trans3.HideSync(panelPatientInfo);
        }

        private void UC_PatientCardDoctor_patientDoctorCardClicked(Patient patient)
        {
            ShowPatientInfo(patient);
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

        private void btnHidePanelDiagnosis_Click(object sender, EventArgs e)
        {
            int nextDiagnosisID = new DiagnosisRepository().GetNextID();
            Diagnosis diagnosis = new Diagnosis(nextDiagnosisID)
            {
                diagnosis = txtPatientDiagnosis.Text,
                diagnosisDate = dtpDiagnosisDate.Value.ToString("yyyy-MM-dd"),
                needAnalysis = Convert.ToByte(cbNeedAnalysis.Checked),
                needRay = Convert.ToByte(cbNeedRays.Checked),
                patient = currentPatient
            };

            if (cbxCheckUp.Checked)
                GetCheckUp();

            if (cbNeedAnalysis.Checked)
                for (int x = 0; x < dgvPatientAnalysis.Rows.Count; x++)
                    GetAnalysis(diagnosis, 1);

            if (cbNeedRays.Checked)
                for (int x = 0; x < dgvPatientRays.Rows.Count; x++)
                    GetAnalysis(diagnosis, 1);

            panelDiagnosisAnim.HideSync(panelDiagnosis);
        }

        private DiagnosisRay GetRays(Diagnosis diagnosis, int raysID)
        {
            DiagnosisRay diagnosisRays = new DiagnosisRay
            {
                diagnosis = diagnosis,
                ray = new RayRepository().RetriveOneRay(raysID)
            };
            return diagnosisRays;
        }

        private DiagnosisAnalysis GetAnalysis(Diagnosis diagnosis, int analysisID)
        {
            DiagnosisAnalysis diagnosisAnalysis = new DiagnosisAnalysis
            {
                diagnosis = diagnosis,
                analysis = new AnalysisRepository().RetriveOneAnalysis(analysisID)
            };
            return diagnosisAnalysis;
        }

        private CheckUp GetCheckUp()
        {
            CheckUp checkUp = new CheckUp()
            {
                patient = currentPatient,
                CheckUpDate = dtpCheckUpDate.Value.ToString("yyyy-MM-dd")
            };
            return checkUp;
        }

        private void btnShowArchieve_Click(object sender, EventArgs e)
        {
            panelDiagnosis.BringToFront();
            panelDiagnosisAnim.ShowSync(panelDiagnosis);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //savabtn>>>>
            insertDiagnoses();
            panelDiagnosisAnim2.HideSync(panelNewDiagnosis);
        }

        private void insertDiagnoses()
        {
            //added
            DiagnosisRepository diagnosisRepository = new DiagnosisRepository();
            DiagnosisRayRepository diagnosisRayRepository = new DiagnosisRayRepository();
            DiagnosisAnalysisRepository diagnosisAnalysisRepository = new DiagnosisAnalysisRepository();
            DiagnosisTreatmentRepository diagnosisTreatmentRepository = new DiagnosisTreatmentRepository();
            //>>>>
            Diagnosis diagnosiss = new Diagnosis
            {
                diagnosisID = new DiagnosisRepository().GetNextID(),
                diagnosis = txtPatientDiagnosis.Text,
                diagnosisDate = dtpDiagnosisDate.Text,
                patient = currentPatient,
                needRay = Convert.ToByte(cbNeedAnalysis.Checked),
                needAnalysis = Convert.ToByte(cbNeedRays.Checked)
            };
            diagnosisRepository.AddDiagnosis(diagnosiss);
            //>>>>
            DiagnosisRay diagnosisRay = new DiagnosisRay
            {


            };
            diagnosisRayRepository.AddDiagnosisRay(diagnosisRay);
            //>>>>
            DiagnosisAnalysis diagnosisAnalysis = new DiagnosisAnalysis
            {

            };
            diagnosisAnalysisRepository.AddDiagnosisAnalysis(diagnosisAnalysis);
            //>>>>>
            DiagnosisTreatment diagnosisTreatment = new DiagnosisTreatment
            {

            };
            diagnosisTreatmentRepository.AddDiagnosisTreatment(diagnosisTreatment);
            //>>>>
            if (cbxCheckUp.Checked)
            {
                CheckUpRepository checkUpRepository = new CheckUpRepository();
                CheckUp checkUp = new CheckUp
                {
                    patient = currentPatient,
                    CheckUpDate = dtpCheckUpDate.Text
                };
                checkUpRepository.AddCheckUp(checkUp);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            panelNewDiagnosis.BringToFront();
            panelDiagnosisAnim2.ShowSync(panelNewDiagnosis);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            panelNewDiagnosis.BringToFront();
            panelDiagnosisAnim2.ShowSync(panelNewDiagnosis);
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)

        {
            panelDiagnosis.BringToFront();
            panelDiagnosisAnim.ShowSync(panelDiagnosis);

            panelNewDiagnosis.Show();
        }

        private void UC_Doctor_Load(object sender, EventArgs e)
        {
            GetAllResevations();
            panelDiagnosis.Hide();
            panelNewDiagnosis.Hide();
            panelPatientInfo.Hide();
        }

        private void GetAllResevations()
        {
            pnlPatientDoctorCards.Controls.Clear();
            reservations = new ReservationRepository().RetriveAllReservations(dtpReservations.Value.ToString("yyyy-MM-dd"), false);
            int queue = 1;
            foreach (Reservation reservation in reservations)
            {
                UC_PatientCardDoctor patientCardDoctor = new UC_PatientCardDoctor(reservation, queue);
                pnlPatientDoctorCards.Controls.Add(patientCardDoctor);
                uC_PatientsCards.Add(patientCardDoctor);
                queue += 1;
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditPatien_Click(object sender, EventArgs e)
        {
            if (currentPatient == null)
            {
                MessageBox.Show("Choose a vaild Patient");
                return;
            }
            if (!panelPatientInfo.Visible)
                trans3.ShowSync(panelPatientInfo);
            else trans3.HideSync(panelPatientInfo);
            panelPatientInfo.Controls.Clear();
            panelPatientInfo.Controls.Add(new UC_PatientSec(currentPatient, CurrentPatientTreatment));
        }

        private void dtpReservations_ValueChanged(object sender, EventArgs e)
        {
            GetAllResevations();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Warning!, All Patient informations will be deleted. Continue Deleteing?","", MessageBoxButtons.YesNo);
            if (msg == DialogResult.No)
                return;
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.DeletePatient(currentPatient);
            GetAllResevations();
        }

        private void dgvRaste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) 
            => HandleColTreatmentTxtCompleter(e);

        private void HandleColTreatmentTxtCompleter(DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvRaste.CurrentCell.ColumnIndex == 0)
            {
                TextBox txtTreatment = e.Control as TextBox;
                if (txtTreatment != null)
                {
                    txtTreatment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtTreatment.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtTreatment.AutoCompleteCustomSource = treatmentsCollection;

                }
            }
            else
            {
                TextBox txtTreatment = e.Control as TextBox;
                if (txtTreatment != null)
                {
                    txtTreatment.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }

        private void HandleColAnalysisTxtCompleter(DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPatientAnalysis.CurrentCell.ColumnIndex == 0)
            {
                TextBox col_Analysis = e.Control as TextBox;
                if (col_Analysis != null)
                {
                    col_Analysis.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    col_Analysis.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    col_Analysis.AutoCompleteCustomSource = AnalysisCollection;

                }
            }
            else
            {
                TextBox col_Analysis = e.Control as TextBox;
                if (col_Analysis != null)
                {
                    col_Analysis.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }

        private void HandleColRaysTxtCompleter(DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPatientRays.CurrentCell.ColumnIndex == 0)
            {
                TextBox col_Rays = e.Control as TextBox;
                if (col_Rays != null)
                {
                    col_Rays.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    col_Rays.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    col_Rays.AutoCompleteCustomSource = RaysCollection;

                }
            }
            else
            {
                TextBox col_Rays = e.Control as TextBox;
                if (col_Rays != null)
                {
                    col_Rays.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }

        private void dgvPatientRays_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            HandleColRaysTxtCompleter(e);
        }

        private void dgvPatientAnalysis_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            HandleColAnalysisTxtCompleter(e);

        }

        private void dgvPatientAnalysis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==(Keys.Control | Keys.Delete))
            {
                foreach (DataGridViewRow item in this.dgvPatientAnalysis.SelectedRows)
                {
                    dgvPatientAnalysis.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dgvPatientRays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Control | Keys.Delete))
            {
                foreach (DataGridViewRow item in this.dgvPatientRays.SelectedRows)
                {
                    dgvPatientRays.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dgvRaste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Control | Keys.Delete))
            {
                foreach (DataGridViewRow item in this.dgvRaste.SelectedRows)
                {
                    dgvRaste.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void dgvPatientAnalysis_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatientAnalysis.CurrentCell.Value == null)
                MessageBox.Show("Analysis can't be empty");
            else if (!AnalysisCollection.Contains(dgvPatientAnalysis.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Invalid Analysis");
            }
        }

        private void dgvPatientAnalysis_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvPatientAnalysis.CurrentCell.Value == null)
                return;
            else if (dgvPatientAnalysis.CurrentCell.Value.ToString() == "")
                MessageBox.Show("Analysis can't be empty");
        }

        private void dgvPatientRays_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvPatientRays.CurrentCell.Value == null)
                return;
            else if (dgvPatientRays.CurrentCell.Value.ToString() == "")
                MessageBox.Show("Ray can't be empty");
        }

        private void dgvPatientRays_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatientRays.CurrentCell.Value == null)
                MessageBox.Show("Ray can't be empty");
            else if (!treatmentsCollection.Contains(dgvPatientRays.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Invalid Ray");
            }
        }

        private void dgvRaste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRaste.CurrentCell.Value == null)
                MessageBox.Show("Treatment can't be empty");
            else if (!treatmentsCollection.Contains(dgvRaste.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Invalid Treatment");
            }
        }

        private void dgvRaste_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvRaste.CurrentCell.Value == null)
                return;
            else if (dgvRaste.CurrentCell.Value.ToString() == "")
                MessageBox.Show("Treatment can't be empty");
        }

        private void cbCheckUp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheckUp.Checked)
            {
                dtpCheckUpDate.Enabled = true;
            }
            else
            {
                dtpCheckUpDate.Enabled = false;
            }
        }

        private void cbNeedAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNeedAnalysis.Checked)
            {
                dgvPatientAnalysis.Enabled = true;
            }
            else
            {
                dgvPatientAnalysis.Enabled = false;
                dgvPatientAnalysis.Rows.Clear();
            }
        }

        private void cbNeedRays_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNeedRays.Checked)
            {
                dgvPatientRays.Enabled = true;
            }
            else
            {
                dgvPatientRays.Enabled = false;
                dgvPatientRays.Rows.Clear();
            }
        }
    }
}

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
using static Clinic.BL.Treatment;
using Guna.UI.WinForms;

namespace ClinicManager.UserControls
{
    public partial class UC_PatientSec : UserControl
    {
        Patient currentPatient;
        public delegate void savePatientInfo(Patient patient);
        public static event savePatientInfo patientInfoSaved;
        Dictionary<string, string> dictTreatments = new Dictionary<string, string>();
        AutoCompleteStringCollection treatmentsCollection = new AutoCompleteStringCollection();
        public UC_PatientSec(Patient patient, DataTable tblTreatment)
        {
            InitializeComponent();
            currentPatient = patient;
            txtName.Text = patient.patientName;
            txtPhone.Text = patient.PatientPhone;
            txtAddress.Text = patient.PatientAddress;
            txtNationalID.Text = patient.patientNationalID;
            txtAge.Text = patient.patientAge.ToString();
            dtBirth.Text = patient.patientBirthDate;
            txtGovernment.Text = patient.patientGovernment;
            txtHistoricalDisease.Text = patient.patientHistoricalDisease;
            txtSufferFrom.Text = patient.patientSufferFrom;
            dgvTreatmentToken.DataSource = tblTreatment;
        }

        private void dgvTreatmentToken_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            HandleColTxtCompleter(e);
        }


        private void GetTreatmentsInfo()
        {
            DataTable tblAllTreatments = new TreatmentRepository().RetriveAllTreatments();
            if (tblAllTreatments.Rows.Count == 0) return;


            for (int x = 0; x < tblAllTreatments.Rows.Count; x++)
            {
                var treatmentID = tblAllTreatments.Rows[x][IDTREATC].ToString();
                var reatmentName = tblAllTreatments.Rows[x][NAMETREATC].ToString();
                dictTreatments.Add(treatmentID, reatmentName);
                treatmentsCollection.Add(reatmentName);
            }


        }

        private void HandleColTxtCompleter(DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTreatmentToken.CurrentCell.ColumnIndex == 0)
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

        private void UC_PatientSec_Load(object sender, EventArgs e)
        {
            GetTreatmentsInfo();
        }


        private void dgvTreatmentToken_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteTreatmentFromDgv(e);
        }

        private void DeleteTreatmentFromDgv(KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Delete))
            {
                foreach (DataGridViewRow item in this.dgvTreatmentToken.SelectedRows)
                {
                    dgvTreatmentToken.Rows.RemoveAt(item.Index);
                }
            }
            else return;
        }

        private void btnSavePatientInfo_Click(object sender, EventArgs e)
        {
            SavePatient(); 
        }

        private void SavePatient()
        {
            try
            {
                PatientRepository PatientRepository = new PatientRepository();
                PatientTreatmentRepository patientTreatmentRepository = new PatientTreatmentRepository();
                Patient Patient = new Patient
                {
                    patientID = currentPatient.patientID,
                    patientName = txtName.Text,
                    PatientPhone = txtPhone.Text,
                    PatientAddress = txtAddress.Text,
                    patientAge = int.Parse(txtAge.Text.ToString()),
                    patientGovernment = txtGovernment.Text,
                    patientBirthDate = dtBirth.Value.ToString("yyyy-MM-dd"),
                    patientNationalID = txtNationalID.Text,
                    patientSufferFrom = txtSufferFrom.Text,
                    patientHistoricalDisease = txtHistoricalDisease.Text

                };
                PatientRepository.SavePatient(Patient);
                patientTreatmentRepository.DeletePatientTreatment(Patient);
                for (int i = 0; i < dgvTreatmentToken.Rows.Count - 1; i++)
                {
                    if(!treatmentsCollection.Contains(dgvTreatmentToken.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Make Sure Treatment Is valid");
                        return;
                    }
                    int treatmentId = int.Parse(dictTreatments.First(x => x.Value == dgvTreatmentToken.Rows[i].Cells[0].Value.ToString()).Key);
                    PatientTreatment patientTreatment = new PatientTreatment(currentPatient.patientID, treatmentId);
                    patientTreatmentRepository.AddPatientTreatment(patientTreatment);
                }
                patientInfoSaved.Invoke(currentPatient);
            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }

        private void dgvTreatmentToken_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvTreatmentToken.CurrentCell.Value == null)
                return;
            else if (dgvTreatmentToken.CurrentCell.Value.ToString() == "")
                MessageBox.Show("Treatment can't be empty");
            
        }


        private void dgvTreatmentToken_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!treatmentsCollection.Contains(dgvTreatmentToken.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Invalid Treatment");
            }
        }
    }
}

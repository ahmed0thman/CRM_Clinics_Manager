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
    public partial class UC_Patient : UserControl
    {
        Dictionary<string, string> dictTreatments = new Dictionary<string, string>();
        AutoCompleteStringCollection treatmentsCollection = new AutoCompleteStringCollection();

        public UC_Patient()
        {
            InitializeComponent();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            //add_patient
            AddPatient();

        }

        private void UC_Patient_Load(object sender, EventArgs e)
        {
            GetTreatmentsInfo();
        }


        private void dgv_Treat_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            HandleColTxtCompleter(e);
        }

        
        #region Functions In Partial Class
        private void AddPatient()
        {
            try
            {
                PatientRepository PatientRepository = new PatientRepository();
                PatientTreatmentRepository patientTreatmentRepository = new PatientTreatmentRepository();
                ReservationRepository reservationRepository = new ReservationRepository();
                int lastID = PatientRepository.getLastPatientID();
                int lastQueue = reservationRepository.GetLastQueueInDate(dt_Rservation.Value.ToString("yyyy-MM-dd"));
                if (lastID == -1)
                {
                    lastID = 100;
                }
                if (lastQueue == -1) lastQueue = 0;
                Patient Patient = new Patient
                {
                    patientID = lastID + 1,
                    patientName = txt_Name.Text,
                    PatientPhone = txt_Phone.Text,
                    PatientAddress = txt_Address.Text,
                    patientAge = int.Parse(txt_Age.Text.ToString()),
                    patientGovernment = txt_Goverment.Text,
                    patientBirthDate = dt_Birth.Value.ToString("yyyy-MM-dd"),
                    patientNationalID = txt_National_ID.Text,
                    patientSufferFrom = txt_Suffer.Text,
                    patientHistoricalDisease = txt_Historical.Text

                };
                PatientRepository.AddPatient(Patient);
                reservationRepository.AddReservation(new Reservation(Patient, dt_Rservation.Value.ToString("yyyy-MM-dd"), lastQueue + 1));
                for (int i = 0; i < dgv_Treat.Rows.Count - 1; i++)
                {
                    if (!treatmentsCollection.Contains(dgv_Treat.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Make Sure Treatment Is valid");
                        return;
                    }
                    int treatmentId = int.Parse(dictTreatments.First(x => x.Value == dgv_Treat.Rows[i].Cells[0].Value.ToString()).Key);
                    PatientTreatment patientTreatment = new PatientTreatment(lastID + 1, treatmentId);
                    patientTreatmentRepository.AddPatientTreatment(patientTreatment);
                }
                WidgetCleaner.ClearControls(panel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
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
            if (dgv_Treat.CurrentCell.ColumnIndex == 0)
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
        #endregion

        private void dgv_Treat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgv_Treat.CurrentCell.Value == null)
                return;
            else if (dgv_Treat.CurrentCell.Value.ToString() == "")
                MessageBox.Show("Treatment can't be empty");
        }

        private void dgv_Treat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Treat.CurrentCell.Value == null)
                MessageBox.Show("Treatment can't be empty");
            else if (!treatmentsCollection.Contains(dgv_Treat.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("Invalid Treatment");
            }
        }

        private void dgv_Treat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Delete))
            {
                    foreach (DataGridViewRow item in this.dgv_Treat.SelectedRows)
                    {
                        dgv_Treat.Rows.RemoveAt(item.Index);
                    }
            }
            else return;
        }
    }
}

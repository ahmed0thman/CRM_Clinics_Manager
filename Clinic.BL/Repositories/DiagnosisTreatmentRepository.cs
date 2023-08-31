using System;
using MySqlControl;
using System.Data;
using static Clinic.BL.DiagnosisTreatment;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class DiagnosisTreatmentRepository
    {
        /// <summary>
        /// Retrieve one DiagnosisTreatment using id
        /// </summary>
        /// <param name="diagnosisID"></param>
        /// <param name="treatmentID"></param>
        /// <returns></returns>
        public DiagnosisTreatment RetriveOneDiagnosisTreatment(int diagnosisID, int treatmentID)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis_treatment where {DIAGNISISC}={diagnosisID} and {TREATMENTC}={treatmentID}";
            var tbl = DB.GetData(query);

            var diagnosis = new DiagnosisRepository().RetriveOneDiagnosis(diagnosisID);
            var treatment = new TreatmentRepository().RetriveOneTreatment(treatmentID);

            var diagnosisTreatment = new DiagnosisTreatment(diagnosis, treatment)
            {
                describtion = tbl.Rows[0][$"{DESCRIPTIONC}"].ToString(),
                
            };

            DB.Close();
            return diagnosisTreatment;
        }

        /// <summary>
        /// Retrive all DiagnosisTreatment data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllDiagnosisTreatment()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis_treatment";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;
        }

        /// <summary>
        /// Adding new DiagnosisTreatment
        /// </summary>
        /// <param name="diagnosisTreatment"></param>
        /// <returns></returns>
        public bool AddDiagnosisTreatment(DiagnosisTreatment diagnosisTreatment)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isDiagnosisTreatmentAdded = true;

            try
            {
                string query = $"insert into diagnosis_treatment({DIAGNISISC}, {TREATMENTC}, {DESCRIPTIONC}) " +
                    $"values({diagnosisTreatment.diagnosis.diagnosisID}, {diagnosisTreatment.treatment.TreatmentID}, " +
                    $"{diagnosisTreatment.describtion})";
                DB.Run(query);
            }
            catch
            {
                isDiagnosisTreatmentAdded = false;
            }
            DB.Close();
            return isDiagnosisTreatmentAdded;
        }

        /// <summary>
        /// Delete current analysis
        /// </summary>
        /// <param name="analysis"></param>
        /// <returns></returns>
        public bool DeletePatient(DiagnosisTreatment diagnosisTreatment)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isDiagnosisTreatmentDeleted = true;

            try
            {
                string query = $"delete from diagnosis_treatment where {DIAGNISISC}={diagnosisTreatment.diagnosis.diagnosisID} and {TREATMENTC}={diagnosisTreatment.treatment.TreatmentID}";
                DB.Run(query);
            }
            catch
            {
                isDiagnosisTreatmentDeleted = false;
            }
            DB.Close();
            return isDiagnosisTreatmentDeleted;
        }
    }
}

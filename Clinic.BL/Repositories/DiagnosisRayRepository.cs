using System;
using System.Data;
using MySqlControl;
using static Clinic.BL.DiagnosisRay;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class DiagnosisRayRepository
    {
        /// <summary>
        /// Retrieve one DiagnosisRay
        /// </summary>
        /// <param name="diagnosisID"></param>
        /// <param name="rayID"></param>
        /// <returns></returns>
        public DiagnosisRay RetriveOneDiagnosisRay(int diagnosisID, int rayID)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis_ray where {DIAGNOSISC}={diagnosisID} and {RAYC}={rayID}";
            var tbl = DB.GetData(query);

            var diagnosis = new DiagnosisRepository().RetriveOneDiagnosis(diagnosisID);
            var ray = new RayRepository().RetriveOneRay(rayID);

            var diagnosisRay = new DiagnosisRay(diagnosis, ray);

            DB.Close();
            return diagnosisRay;
        }

        /// <summary>
        /// Retrive all DiagnosisRay data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllDiagnosisRay()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis_ray";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;
        }

        /// <summary>
        /// Adding new DiagnosisRay
        /// </summary>
        /// <param name="diagnosisRay"></param>
        /// <returns></returns>
        public bool AddDiagnosisRay(DiagnosisRay diagnosisRay)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isDiagnosisRayAdded = true;

            try
            {
                string query = $"insert into diagnosis_ray({DIAGNOSISC}, {RAYC}) " +
                    $"values({diagnosisRay.diagnosis.diagnosisID}, {diagnosisRay.ray.rayID})";
                DB.Run(query);
            }
            catch
            {
                isDiagnosisRayAdded = false;
            }
            DB.Close();
            return isDiagnosisRayAdded;
        }

        /// <summary>
        /// Delete current DiagnosisAnalysis
        /// </summary>
        /// <param name="diagnosisAnalysis"></param>
        /// <returns></returns>
        public bool DeleteReservation(DiagnosisRay diagnosisRay)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool iDiagnosisRayDeleted = true;

            try
            {
                string query = $"delete from diagnosis_ray where {DIAGNOSISC}={diagnosisRay.diagnosis.diagnosisID} and {RAYC}={diagnosisRay.ray.rayID}";
                DB.Run(query);
            }
            catch
            {
                iDiagnosisRayDeleted = false;
            }
            DB.Close();
            return iDiagnosisRayDeleted;
        }
    }
}

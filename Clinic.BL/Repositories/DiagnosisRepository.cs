using MySqlControl;
using System;
using System.Data;
using static Clinic.BL.Diagnosis;
using static Clinic.BL.ConnectionString;
using System.Collections.Generic;

namespace Clinic.BL
{
    public class DiagnosisRepository
    {
        /// <summary>
        /// Retrieve one Diagnosis
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Diagnosis RetriveOneDiagnosis(int id)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis where {IDC}={id}";
            var tbl = DB.GetData(query);
            int diagnosisPatientID = int.Parse(tbl.Rows[0][$"{Patient.IDC}"].ToString());
            var patient = new PatientRepository().RetriveOnePatient(diagnosisPatientID);

            var diagnosis = new Diagnosis(id, patient)
            {
                diagnosis = tbl.Rows[0][$"{DIAGNOSISC}"].ToString(),
                diagnosisDate = tbl.Rows[0][$"{_DATEC}"].ToString(),
                needRay = byte.Parse(tbl.Rows[0][$"{NEED_RAYC}"].ToString()),
                needAnalysis = byte.Parse(tbl.Rows[0][$"{NEED_ANALYSISC}"].ToString())
            };

            DB.Close();
            return diagnosis;
        }

        /// <summary>
        /// Retrive all Diagnosis data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllDiagnosis()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;
        }

        public List<Diagnosis> RetriveAllDiagnosis(string whereCondition)
        {
            var DB = new MySqlClass(ConnStr);
            List<Diagnosis> diagnosesses = new List<Diagnosis>();
            DB.Open();
            string query = $"select * from diagnosis where {whereCondition}";
            var tbl = DB.GetData(query);
            for (int x = 0; x < tbl.Rows.Count; x++)
            {
                Diagnosis diagnosis = new Diagnosis
                {
                    diagnosisID = (int)tbl.Rows[x][IDC],
                    diagnosis = tbl.Rows[x][DIAGNOSISC].ToString(),
                    diagnosisDate = tbl.Rows[x][_DATEC].ToString(),
                    needAnalysis = (byte)tbl.Rows[x][NEED_RAYC],
                    needRay = (byte)tbl.Rows[x][NEED_RAYC],
                    patient = new PatientRepository().RetriveOnePatient(int.Parse(tbl.Rows[x][PATIENTC].ToString()))
                };
            }
            DB.Close();
            return diagnosesses;
        }

        /// <summary>
        /// Adding new diagnosis
        /// </summary>
        /// <param name="diagnosis"></param>
        /// <returns></returns>
        public bool AddDiagnosis(Diagnosis diagnosis)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool iSReservationAdded = true;
            try
            {
                string query = $"insert into diagnosis({IDC}, {PATIENTC}, {DIAGNOSISC}, {_DATEC}, {NEED_RAYC}, {NEED_ANALYSISC}) " +
                    $"values({diagnosis.diagnosisID}, {diagnosis.patient.patientID}," +
                    $" '{diagnosis.diagnosisDate}', {diagnosis.needRay}, {diagnosis.needAnalysis})";
                DB.Run(query);
            }
            catch
            {
                iSReservationAdded = false;
            }
            DB.Close();
            return iSReservationAdded;
        }

        public int GetNextID()
        {
            int NextID = -1;
            var DB = new MySqlClass(ConnStr);
            try
            {
                
                DB.Open();
                
                var tbl = DB.GetData($"select max({IDC}) from diagnosis");
                if(tbl.Rows.Count > 0)
                {
                    NextID = int.Parse(tbl.Rows[0][IDC].ToString()) + 1;
                }
                DB.Close();
                return NextID;
            }
            catch (Exception ex)
            {
                DB.Close();
                return NextID;
                throw (ex);
            }
        }

        /// <summary>
        /// Delete current Reservation
        /// </summary>
        /// <param name="diagnosis"></param>
        /// <returns></returns>
        public bool DeleteReservation(Diagnosis diagnosis)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isDiagnosisDeleted = true;

            try
            {
                string query = $"delete from diagnosis where {IDC}={diagnosis.diagnosisID}";
                DB.Run(query);
            }
            catch
            {
                isDiagnosisDeleted = false;
            }
            DB.Close();
            return isDiagnosisDeleted;
        }
    }
}

using System;
using MySqlControl;
using System.Data;
using static Clinic.BL.CheckUp;
using static Clinic.BL.ConnectionString;
using static Clinic.BL.Patient;
using System.Security;

namespace Clinic.BL
{
    public class CheckUpRepository
    {
        /// <summary>
        /// Retrieve one CheckUp
        /// </summary>
        /// <param name="patientID"></param>
        /// <param name="CheckUpDate"></param>
        /// <returns></returns>
        public CheckUp RetriveOneCheckUp(int patientID, string CheckUpDate)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            var patient = new PatientRepository().RetriveOnePatient(patientID);
            string query = $"select * from check_up where {PATIENTC}={patientID} and {_DATEC}={CheckUpDate}";
            var tbl = DB.GetData(query);
            var checkUp = new CheckUp
            {
                patient = patient,
                CheckUpDate = tbl.Rows[0][$"{_DATEC}"].ToString()
            };
            DB.Close();
            return checkUp;
        }

        /// <summary>
        /// Retrive all CheckUps data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllCheckUps(string date)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            var tbl = DB.GetData($"select patient.{NAMEC} as patient, patient.{PHONEC} as phone from check_up" +
                $" inner join patient on check_up.{PATIENTC} = patient.{IDC}" +
                $" where {_DATEC} = '{date}'");
            DB.Close();
            return tbl;
        }

        /// <summary>
        /// Adding new CheckUp
        /// </summary>
        /// <param name="checkUp"></param>
        /// <returns></returns>
        public bool AddCheckUp(CheckUp checkUp)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isCheckUpAdded = true;

            try
            {
                string query = $"insert into check_up({PATIENTC}, {_DATEC}) values({checkUp.patient.patientID}, '{checkUp.CheckUpDate}')";
                DB.Run(query);
            }
            catch
            {
                isCheckUpAdded = false;
            }
            DB.Close();
            return isCheckUpAdded;
        }

        /// <summary>
        /// Delete current CheckUp
        /// </summary>
        /// <param name="checkUp"></param>
        /// <returns></returns>
        public bool DeleteCheckUp(CheckUp checkUp)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isCheckUpDeleted = true;

            try
            {
                string query = $"delete from check_up where {PATIENTC}={checkUp.patient.patientID} and {_DATEC}='{checkUp.CheckUpDate}'";
                DB.Run(query);
            }
            catch
            {
                isCheckUpDeleted = false;
            }

            DB.Close();
            return isCheckUpDeleted;
        }

        /// <summary>
        /// Edit the current CheckUp new data
        /// </summary>
        /// <returns></returns>
        public bool SaveCheckUp(CheckUp checkUp)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isCheckUpSaved = true;

            try
            {
                string query = $"update check_up set {_DATEC}='{checkUp.CheckUpDate}' " +
                    $"where {PATIENTC}={checkUp.patient.patientID} and {_DATEC}='{checkUp.CheckUpDate}'";
                DB.Run(query);
            }
            catch
            {
                isCheckUpSaved = false;
            }
            DB.Close();
            return isCheckUpSaved;
        }
    }
}

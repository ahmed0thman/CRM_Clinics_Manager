using System.Collections.Generic;
using MySqlControl;
using System.Data;
using static Clinic.BL.Treatment;
using static Clinic.BL.ConnectionString;
using System.Data.Common;
using System.IO;
using System;
namespace Clinic.BL
{
    public class TreatmentRepository
    {
        public Treatment RetriveOneTreatment(int id)
        {
            // Code to get required Treatment
            // ..

            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from treatments where {IDTREATC}={id}";
            var tbl = DB.GetData(query);
            var treatment = new Treatment
            {

                TreatmentID = id,
                TreatmentName = tbl.Rows[0][$"{NAMETREATC}"].ToString()
            };
            DB.Close();
            return treatment;

        }


        /// <summary>
        /// Retrive all Treatments data in DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllTreatments()
        {
            // Code to get required Treatments
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from treatments";
            DataTable tblTreatment = DB.GetData(query);
            return tblTreatment;
        }


        /// <summary>
        /// Retrive all Treatments data in List<Treatment>
        /// </summary>
        /// <returns></returns>
        public List<Treatment> RetriveAllTreatment()
        {
            // Code to get required Ray
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from treatments";
            var tbl = DB.GetData(query);
            List<Treatment> Treatment = new List<Treatment>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                Treatment treat = new Treatment
                {
                    TreatmentID = int.Parse(tbl.Rows[i][$"{IDTREATC}"].ToString()),
                    TreatmentName = tbl.Rows[i][$"{NAMETREATC}"].ToString()
                };
                Treatment.Add(treat);
            }

            DB.Close();
            return Treatment;
        }

        /// <summary>
        /// Adding new Treatment
        /// </summary>
        /// <param name="Treatment"></param>
        /// <returns></returns>
        public bool AddTreatment(Treatment treatment)
        {
            bool iSTreatmentAdded = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to add data
                // ..
                string query = $"insert into treatments(" +
                   $"{NAMETREATC})" +
                   $" VALUES(" +
                   $"'{treatment.TreatmentName}')";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSTreatmentAdded = false;
                throw (ex);
            }
            DB.Close();
            return iSTreatmentAdded;
        }

        /// <summary>
        /// Delete current Treatment
        /// </summary>
        /// <param name="Treatment"></param>
        /// <returns></returns>
        public bool DeleteTreatment(string id)
        {
            bool isTreatmentDeleted = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to delete data
                // ..
                string query = $" delete from treatments where {IDTREATC} = {id}";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                isTreatmentDeleted = false;
                throw (ex);
            }
            DB.Close();

            return isTreatmentDeleted;
        }

        /// <summary>
        /// Save the current Treatment new data
        /// </summary>
        /// <returns></returns>
        public bool SaveTreatment(Treatment treatment)
        {
            bool isTreatmentSaved = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to save data
                // ..
                string query = $"update treatments set  {NAMETREATC}='{treatment.TreatmentName}" +
               $" where {IDTREATC}={treatment.TreatmentID}";

                DB.Run(query);

            }
            catch (Exception ex)
            {
                isTreatmentSaved = false;
                throw (ex);
            }
            DB.Close();

            return isTreatmentSaved;
        }
    }
}

using System.Collections.Generic;
using MySqlControl;
using System.Data;
using static Clinic.BL.PatientTreatment;
using static Clinic.BL.Treatment;
using System.Data.Common;
using System.IO;
using System;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class PatientTreatmentRepository
    {
        /// <summary>
        /// Retrieve one PatientTreatment using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>PatientTreatment</returns>
        public DataTable RetriveOnePatientTreatments(int id)
        {
            // Code to get required PatientTreatment
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select treatments.{NAMETREATC} as treatment from patient_treatment"
                + $" inner join treatments on patient_treatment.treatment = treatments.{IDTREATC}"
                + $" where patient_treatment.{PATIENTIDC}={id}";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;

           // return new PatientTreatment(id);
        }

        /// <summary>
        /// Retrive all PatientTreatments data
        /// </summary>
        /// <returns></returns>
        public List<PatientTreatment> RetriveAllPatientTreatments()
        {
            // Code to get required PatientTreatments
            // ..
            return new List<PatientTreatment>();
        }

        /// <summary>
        /// Adding new PatientTreatment
        /// </summary>
        /// <param name="patientTreatment"></param>
        /// <returns></returns>
        public bool AddPatientTreatment(PatientTreatment patientTreatment)
        {
            bool iSPatientTreatmentAdded = true;

                // Code to add data
                // ..
                var DB = new MySqlClass(ConnStr);
                DB.Open();
                try
                {
                    string query = $"insert into patient_treatment(" +
                        $"{PATIENTIDC}, {TREATMENTC})" +
                        $" VALUES(" +
                        $"{patientTreatment.PatientTreatmentID}, '{patientTreatment.PatientTreatmentName}')";
                    DB.Run(query);
                }
                catch(Exception ex)
                {
                    iSPatientTreatmentAdded = false;
                    throw (ex);
                }
                DB.Close();
                return iSPatientTreatmentAdded;

         
        }

        /// <summary>
        /// Delete current PatientTreatment
        /// </summary>
        /// <param name="patientTreatment"></param>
        /// <returns></returns>
        public bool DeletePatientTreatment(Patient patient)
        {
            bool isPatientTreatmentDeleted = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();

            try
            {
                // Code to delete data
                // ..
                string query = $" delete from patient_treatment where {PATIENTIDC} = {patient.patientID}";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                isPatientTreatmentDeleted = false;
                throw (ex);
            }
            DB.Close();

            return isPatientTreatmentDeleted;
        }

        /// <summary>
        /// Save the current PatientTreatment new data
        /// </summary>
        /// <returns></returns>
        public bool SavePatientTreatment(PatientTreatment patientTreatment)
        {
            bool isPatientTreatmentSaved = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to save data
                // ..
                string query = $"update patient_treatment set  {TREATMENTC}='{patientTreatment.PatientTreatmentName}" +
                    $" where {PATIENTIDC}={patientTreatment.PatientTreatmentID}";
              
                DB.Run(query);

            }
            catch (Exception ex)
            {
                isPatientTreatmentSaved = false;
                throw (ex);
            }
            DB.Close();

            return isPatientTreatmentSaved;
        }
    }
}

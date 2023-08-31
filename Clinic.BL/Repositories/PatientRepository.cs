using System.Collections.Generic;
using MySqlControl;
using System.Data;
using static Clinic.BL.Patient;
using System.Data.Common;
using System.IO;
using System;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class PatientRepository
    {
        /// <summary>
        /// Retrieve one Patient using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Patient</returns>
        public Patient RetriveOnePatient(int id)
        {
            try
            {
                var DB = new MySqlClass(ConnStr);
                DB.Open();
                string query = $"select * from patient where {IDC}={id}";
                var tbl = DB.GetData(query);
                var patient = new Patient
                {

                    patientID = id,
                    patientName = tbl.Rows[0][$"{NAMEC}"].ToString(),
                    PatientPhone = tbl.Rows[0][$"{PHONEC}"].ToString(),
                    PatientAddress = tbl.Rows[0][$"{ADDRESSC}"].ToString(),
                    patientNationalID = tbl.Rows[0][$"{NATIONALIDC}"].ToString(),

                    patientAge = int.Parse(tbl.Rows[0][$"{AGEC}"].ToString()),

                    patientBirthDate = tbl.Rows[0][$"{BIRTHC}"].ToString(),

                    patientGovernment = tbl.Rows[0][$"{GOVERMENTC}"].ToString(),

                    patientSufferFrom = tbl.Rows[0][$"{SUFFERC}"].ToString(),

                    patientHistoricalDisease = tbl.Rows[0][$"{HISTORICALC}"].ToString()


                };
                DB.Close();
                return patient;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Retrive all Patients data
        /// </summary>
        /// <returns></returns>
        public List<Patient> RetriveAllPatients()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from patient";
            var tbl = DB.GetData(query);
            List<Patient> patients = new List<Patient>();
            for (int i = 0; i < tbl.Rows.Count ; i++)
            {
                Patient patient = new Patient
                {

                    patientID = int.Parse(tbl.Rows[i][$"{IDC}"].ToString()),
                    patientName = tbl.Rows[i][$"{NAMEC}"].ToString(),
                    PatientPhone = tbl.Rows[i][$"{PHONEC}"].ToString(),
                    PatientAddress = tbl.Rows[i][$"{ADDRESSC}"].ToString(),
                    patientNationalID = tbl.Rows[i][$"{NATIONALIDC}"].ToString(),

                    patientAge = int.Parse(tbl.Rows[i][$"{AGEC}"].ToString()),

                    patientBirthDate = tbl.Rows[i][$"{BIRTHC}"].ToString(),

                    patientGovernment = tbl.Rows[i][$"{GOVERMENTC}"].ToString(),

                    patientSufferFrom = tbl.Rows[i][$"{SUFFERC}"].ToString(),

                    patientHistoricalDisease = tbl.Rows[i][$"{HISTORICALC}"].ToString()


                };
                patients.Add(patient);
            }
            
            DB.Close();
            return patients;
        }

        /// <summary>
        /// Adding new Patient
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool AddPatient(Patient patient)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isPatientAdded = true;

            try
            {
                string query = $"insert into patient(" +
                    $"{IDC}, {NAMEC}, {PHONEC}, {ADDRESSC}, {NATIONALIDC}, {AGEC}, {BIRTHC}, {GOVERMENTC},{SUFFERC}, {HISTORICALC})" +
                    $" VALUES(" +
                    $"'{patient.patientID}', '{patient.patientName}', '{patient.PatientPhone}', '{patient.PatientAddress}', '{patient.patientNationalID}', " +
                    $"{patient.patientAge}, '{patient.patientBirthDate}', '{patient.patientGovernment}', '{patient.patientSufferFrom}', '{patient.patientHistoricalDisease}')";
                DB.Run(query);
            }
            catch
            {
                isPatientAdded = false;
                throw;
            }
            DB.Close();
            return isPatientAdded;
        }

        /// <summary>
        /// Delete current Patient
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>bool</returns>
        public bool DeletePatient(Patient patient)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isPatientDeleted = true;

            try
            {
                string query =$" delete from patient where {IDC} = {patient.patientID}";
                DB.Run(query);
            }
            catch
            {
                isPatientDeleted = false;
            }
            DB.Close();
            return isPatientDeleted;
        }

        /// <summary>
        /// Save the current Patient edit
        /// </summary>
        /// <returns>bool</returns>
        public bool SavePatient(Patient patient)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isPatientSaved = true;

            try
            {
                // Code to save data
                // ..
                string query1 = $"update patient set " +
                   $"{NAMEC} = '{patient.patientName}', {PHONEC} = '{patient.PatientPhone}', {ADDRESSC} = '{patient.PatientAddress}',"
                   +$" {NATIONALIDC} = '{patient.patientNationalID}', {AGEC} = {patient.patientAge}, {BIRTHC} = '{patient.patientBirthDate}',"
                   +$" {GOVERMENTC} = '{patient.patientGovernment}', {SUFFERC} = '{patient.patientSufferFrom}', {HISTORICALC} = '{patient.patientHistoricalDisease}'" 
                   + $"where {IDC} = {patient.patientID}";
                DB.Run(query1);
            }
            catch
            {
                isPatientSaved = false;
                throw;
            }
            DB.Close();
            return isPatientSaved;
        }

        /// <summary>
        /// Get the Last patient ID 
        /// </summary>
        /// <returns>int</returns>
        public int getLastPatientID()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            int id = -1;
            try
            {
                string query = $"select max({IDC}) as id from patient";
                var tbl = DB.GetData(query);
                id =  int.Parse(tbl.Rows[0][IDC].ToString());
                DB.Close();
                return id;
            }
            catch (Exception)
            {
                DB.Close();
                return id;
            }
           
        }
    }
}

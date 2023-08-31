using System;
using Clinic.Common;

namespace Clinic.BL
{
    public class Diagnosis : EntityBase, ILoggable
    {
        #region Constructors
        public Diagnosis() { }

        public Diagnosis(int? diagnosisID)
        {
            this.diagnosisID = diagnosisID;
        }

        public Diagnosis(int? diagnosisID, Patient patient)
            : this(diagnosisID)
        {
            this.patient = patient;
        }

        public Diagnosis(int? diagnosisID, Patient patient, string diagnosis)
             : this(diagnosisID, patient)
        {
            this.diagnosis = diagnosis;
        }

        public Diagnosis(int? diagnosisID, Patient patient, string diagnosis, string diagnosisDate)
            : this(diagnosisID, patient, diagnosis)
        {
            this.diagnosisDate = diagnosisDate;
        }

        public Diagnosis(int? diagnosisID, Patient patient, string diagnosis, string diagnosisDate, byte diagnosisRay)
            : this(diagnosisID, patient,  diagnosis, diagnosisDate)
        {
            this.needRay = diagnosisRay;
        }

        public Diagnosis(int? diagnosisID, Patient patient, string diagnosis, string diagnosisDate, byte diagnosisRay, byte diagnosisAnalysis)
            : this(diagnosisID, patient, diagnosis, diagnosisDate, diagnosisRay)
        {
            this.needAnalysis = diagnosisAnalysis;
        }
        #endregion

        #region Fields and properities
        public int? diagnosisID { get; set; }
        public Patient patient { get; set; }
        public string diagnosis { get; set; }
        public string diagnosisDate { get; set; }
        public byte needRay { get; set; }
        public byte needAnalysis { get; set; }
        #endregion

        #region Fields in database
        public static string IDC { get; set; } = "id";
        public static string PATIENTC { get; set; } = "patient";
        public static string DIAGNOSISC { get; set; } = "diagnosis";
        public static string _DATEC { get; set; } = "_date";
        public static string NEED_RAYC { get; set; } = "need_ray";
        public static string NEED_ANALYSISC { get; set; } = "need_analysis";
        #endregion

        #region Methods
        /// <summary>
        /// patient Name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{patient}";

        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (!patient.Validate()) isValidUser = false;
            if (diagnosis == null) isValidUser = false;
            if (needAnalysis == null) isValidUser = false;
            if (needRay == null) isValidUser = false;

            return isValidUser;
        }

        public string Log() => $"Diagnosis ID :{diagnosisID}, Patient name: {patient}, Diagnosis: {diagnosis}";
        #endregion
    }
}

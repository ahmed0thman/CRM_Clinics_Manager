using Clinic.Common;
using System;

namespace Clinic.BL
{
    public class PatientTreatment : EntityBase, ILoggable
    {
        #region Constructors
        public PatientTreatment() { }

        public PatientTreatment(int PatientTreatmentID)
        {
            this.PatientTreatmentID = PatientTreatmentID;
        }

        public PatientTreatment(int PatientTreatmentID, int PatientTreatmentName) 
            : this(PatientTreatmentID)
        {
            this.PatientTreatmentName = PatientTreatmentName;
        }
        #endregion

        #region Fields and properities
        public int PatientTreatmentID { get;  set; }
        public int PatientTreatmentName { get; set; }
        #endregion

        #region Fields in database
        public static string PATIENTIDC { get; set; } = "patient";
        public static string TREATMENTC { get; set; } = "treatment";
        #endregion

        #region Methods
        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (PatientTreatmentID == null) isValidUser = false;
            if (PatientTreatmentName == null) isValidUser = false;
            
            return isValidUser;
        }

        /// <summary>
        /// Patient Treatment Name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => PatientTreatmentName.ToString();

        public string Log() => $"Patient Treatment ID: {PatientTreatmentID}, PatientTreatmentName: {PatientTreatmentName}";
        #endregion
    }
}

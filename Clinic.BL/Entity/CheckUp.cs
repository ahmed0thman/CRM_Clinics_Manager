using Clinic.Common;
using System;

namespace Clinic.BL
{
    public class CheckUp : EntityBase, ILoggable
    {
        #region Constructors
        public CheckUp() { }

        public CheckUp(Patient patient)
        {
            this.patient = patient;
        }

        public CheckUp(Patient patient, string CheckUpDate)
            : this(patient)
        {
            this.CheckUpDate = CheckUpDate;
        }
        #endregion

        #region Fields and properities
        public Patient patient { get; set; }
        public string CheckUpDate { get; set; }
        #endregion

        #region Fields in database
        public static string PATIENTC { get; set; } = "patient";
        public static string _DATEC { get; set; } = "_date";
        #endregion

        #region Methods
        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (patient.Validate()) isValidUser = false;
            if (CheckUpDate == null) isValidUser = false;

            return isValidUser;
        }

        public string Log() => $"Patent ID :{patient.patientID}, Date: {CheckUpDate}";
        #endregion
    }
}

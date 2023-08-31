using System;
using Clinic.Common;

namespace Clinic.BL
{
    public class Patient : EntityBase, ILoggable
    {
        #region Constructors
        public Patient() { }

        public Patient(int PatientID)
        {
            this.patientID = PatientID;
        }

        public Patient(int PatientID, string patientName)
            : this(PatientID)
        {
            this.patientName = patientName;
        }

        public Patient(int PatientID, string patientName, string patientPhone)
            : this(PatientID, patientName)
        {
            this.PatientPhone = patientPhone;
        }

        public Patient(int PatientID, string patientName, string patientPhone, string PatientAddress)
            : this(PatientID, patientName, patientPhone)
        {
            this.PatientAddress = PatientAddress;
        }

        public Patient(int PatientID, string patientName, string patientPhone, string PatientAddress, string patientNationalID)
            : this(PatientID, patientName, patientPhone, PatientAddress)
        {
            this.patientNationalID = patientNationalID;
        }

        public Patient(int PatientID, string patientName, string patientPhone, string PatientAddress, string patientNationalID, int patientAge)
            : this(PatientID, patientName, patientPhone, PatientAddress, patientNationalID)
        {
            this.patientAge = patientAge;
        }

        public Patient(int PatientID, string patientName, string patientPhone, string PatientAddress, string patientNationalID, int patientAge, string patientPirthDate)
            : this(PatientID, patientName, patientPhone, PatientAddress, patientNationalID, patientAge)
        {
            this.patientBirthDate = patientPirthDate;
        }

        public Patient(int PatientID, string patientName, string patientPhone, string PatientAddress, string patientNationalID, int patientAge, string patientPirthDate, string patientGovernment)
            : this(PatientID, patientName, patientPhone, PatientAddress, patientNationalID, patientAge, patientPirthDate)
        {
            this.patientGovernment = patientGovernment;
        }
        #endregion

        #region Fields and properities
        public int patientID { get; set; }
        public string patientName { get; set; }
        public string PatientPhone { get; set; }
        public string PatientAddress { get; set; }
        public string patientNationalID { get; set; }
        public int? patientAge { get; set; }
        public string patientBirthDate { get; set; }
        public string patientGovernment { get; set; }
        public string patientSufferFrom { get; set; }
        public string patientHistoricalDisease { get; set; }
        #endregion

        #region fields in database
        public static string IDC { get; set; } = "id";
        public static string NAMEC { get; set; } = "name";
        public static string PHONEC { get; set; } = "phone";
        public static string ADDRESSC { get; set; } = "address";
        public static string NATIONALIDC { get; set; } = "nationalID";
        public static string AGEC { get; set; } = "age";
        public static string BIRTHC { get; set; } = "birth_date";
        public static string GOVERMENTC { get; set; } = "government";
        public static string SUFFERC { get; set; } = "suffer_from";
        public static string HISTORICALC { get; set; } = "historical_disease";
        #endregion

        #region Methods
        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns>bool</returns>
        public override bool Validate()
        {
            bool isValidPatient = true;

            if (patientName == null) isValidPatient = false;
            if (PatientPhone == null) isValidPatient = false;
            if (patientNationalID == null) isValidPatient = false;
            if (patientAge == null) isValidPatient = false;

            return isValidPatient;
        }

        /// <summary>
        /// User name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => patientName;

        public string Log() => $"Patient ID:{patientID}, Patient Name: {patientName}, Patient Mobile: {PatientPhone}";
        #endregion
    }
}
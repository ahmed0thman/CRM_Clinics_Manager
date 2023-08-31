using System;
using Clinic.Common;

namespace Clinic.BL
{
    public class Reservation : EntityBase, ILoggable
    {
        #region Constructors
        public Reservation() { }

        public Reservation(Patient patient)
        {
            this.patient = patient;
        }

        public Reservation(Patient patient, string reservationDate)
            : this(patient)
        {
            this.reservationDate = reservationDate;
        }
        public Reservation(Patient patient, string reservationDate, int reservationQueue)
            : this(patient, reservationDate)
        {
            this.reservationQueue = reservationQueue;
        }
        #endregion

        #region Fields and properities
        public Patient patient { get; set; }

        public string reservationDate { get; set; }
        public int reservationQueue { get; set; }
        #endregion

        #region Fields in database
        public static string IDPATIENTRESC { get; set; } = "patient";
        public static string PATIENTDATEC { get; set; } = "_date";
        public static string PATIENTQUEUEC { get; set; } = "queue";
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
            if (reservationDate == null) isValidUser = false;
            if (reservationQueue == null) isValidUser = false;

            return isValidUser;
        }

        /// <summary>
        /// Patient name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => patient.patientName;

        public string Log() => $"patient ID: {patient.patientID}, Date: {reservationDate}, Queue: {reservationQueue}";
        #endregion
    }
}

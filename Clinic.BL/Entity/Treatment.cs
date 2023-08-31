using Clinic.Common;

namespace Clinic.BL
{
    public class Treatment : EntityBase, ILoggable
    {
        #region Constructors
        public Treatment() { }

        public Treatment(int TreatmentID)
        {
            this.TreatmentID = TreatmentID;
        }

        public Treatment(int TreatmentID, string TreatmentName)
            : this(TreatmentID)
        {
            this.TreatmentName = TreatmentName;
        }
        #endregion

        #region Fields and properities
        public int? TreatmentID { get; set; }
        public string TreatmentName { get; set; }
        #endregion

        #region Fields in database
        public static string IDTREATC { get; set; } = "id";
        public static string NAMETREATC { get; set; } = "name";
        #endregion

        #region Methods
        /// <summary>
        /// Treatment Name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{TreatmentName}";

        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (TreatmentID == null) isValidUser = false;
            if (TreatmentName == null) isValidUser = false;

            return isValidUser;
        }

        public string Log() => $"Treatment ID :{TreatmentID}, Treatment name: {TreatmentName}";
        #endregion
    }
}

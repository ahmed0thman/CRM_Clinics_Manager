using Clinic.Common;

namespace Clinic.BL
{
    public enum IntervalType
    {
        type1,
        type2
    }
    public enum DurationType
    {
        type1,
        type2
    }
    public class DiagnosisTreatment : EntityBase, ILoggable
    {
        #region Constructors
        public DiagnosisTreatment() { }

        public DiagnosisTreatment(Diagnosis diagnosis)
        {
            this.diagnosis = diagnosis;
        }

        public DiagnosisTreatment(Diagnosis diagnosis, Treatment treatment)
            : this(diagnosis)
        {
            this.treatment = treatment;
        }

        public DiagnosisTreatment(Diagnosis diagnosis, Treatment treatment, string describtion)
            : this(diagnosis, treatment)
        {
            this.describtion = describtion;
        }

       
        #endregion

        #region Fields and properities
        public Diagnosis diagnosis { get; set; }
        public Treatment treatment { get; set; }
        
        public string describtion { get; set; }
        
        #endregion

        #region Fields in Database
        public static string DIAGNISISC { get; set; } = "diagnosis";
        public static string TREATMENTC { get; set; } = "treatment";
        public static string DESCRIPTIONC { get; set; } = "describtion";
       
        #endregion

        #region Methods
        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (!diagnosis.Validate()) isValidUser = false;
            if (describtion == null) isValidUser = false;
            

            return isValidUser;
        }

        public string Log() => $"Diagnosis ID :{diagnosis.diagnosisID}, Describtion: {describtion}";
        #endregion
    }
}

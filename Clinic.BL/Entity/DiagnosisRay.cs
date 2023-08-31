using Clinic.Common;

namespace Clinic.BL
{
    public class DiagnosisRay : EntityBase, ILoggable
    {
        #region Constructors
        public DiagnosisRay() { }

        public DiagnosisRay(Diagnosis dignosis)
        {
            this.diagnosis = dignosis;
        }

        public DiagnosisRay(Diagnosis dignosis, Ray ray)
            : this(dignosis)
        {
            this.ray = ray;
        }
        #endregion

        #region Fields and properities
        public Diagnosis diagnosis { get; set; }
        public Ray ray { get; set; }
        #endregion

        #region Fields in database
        public static string DIAGNOSISC { get; set; } = "diagnosis";
        public static string RAYC { get; set; } = "ray";
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
            if (!ray.Validate()) isValidUser = false;

            return isValidUser;
        }

        public string Log() => $"Diagnosis ID :{diagnosis.diagnosisID}, Ray Name: {ray}";
        #endregion
    }
}

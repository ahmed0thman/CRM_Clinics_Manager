using Clinic.Common;

namespace Clinic.BL
{
    public class DiagnosisAnalysis : EntityBase, ILoggable
    {
        #region Constructors
        public DiagnosisAnalysis() { }

        public DiagnosisAnalysis(Diagnosis dignosisAnalysis)
        {
            this.diagnosis = dignosisAnalysis;
        }

        public DiagnosisAnalysis(Diagnosis dignosisAnalysis, Analysis analysis)
            : this(dignosisAnalysis)
        {
            this.analysis = analysis;
        }
        #endregion

        #region Fields and properities
        public Diagnosis diagnosis { get; set; }
        public Analysis analysis { get; set; }
        #endregion

        #region Fields in database
        public static string DIAGNOSISC { get; set; } = "diagnosis";
        public static string ANALYSISC { get; set; } = "analysis";
        #endregion

        #region Methods
        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (!analysis.Validate()) isValidUser = false;
            if (!diagnosis.Validate()) isValidUser = false;

            return isValidUser;
        }

        public string Log() => $"Analysis ID :{analysis.analysisID}, Analysis Name: {analysis}";
        #endregion
    }
}

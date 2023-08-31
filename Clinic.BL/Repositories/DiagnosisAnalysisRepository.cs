using System;
using System.Data;
using MySqlControl;
using static Clinic.BL.DiagnosisAnalysis;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class DiagnosisAnalysisRepository
    {
        /// <summary>
        /// Retrieve one DiagnosisAnalysis
        /// </summary>
        /// <param name="diagnosisID"></param>
        /// <param name="analysisID"></param>
        /// <returns></returns>
        public DiagnosisAnalysis RetriveOneDiagnosisAnalysis(int diagnosisID, int analysisID)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis_analysis where {DIAGNOSISC}={diagnosisID} and {ANALYSISC}={analysisID}";
            var tbl = DB.GetData(query);

            var diagnosis = new DiagnosisRepository().RetriveOneDiagnosis(diagnosisID);
            var analysis = new AnalysisRepository().RetriveOneAnalysis(analysisID);

            var diagnosisAnalysis = new DiagnosisAnalysis(diagnosis, analysis);

            DB.Close();
            return diagnosisAnalysis;
        }

        /// <summary>
        /// Retrive all DiagnosisAnalysis data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllDiagnosisAnalysis()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from diagnosis_analysis";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;
        }

        /// <summary>
        /// Adding new DiagnosisAnalysis
        /// </summary>
        /// <param name="diagnosisAnalysis"></param>
        /// <returns></returns>
        public bool AddDiagnosisAnalysis(DiagnosisAnalysis diagnosisAnalysis)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isDiagnosisAnalysisAdded = true;

            try
            {
                string query = $"insert into diagnosis_analysis({DIAGNOSISC}, {ANALYSISC}) " +
                    $"values({diagnosisAnalysis.diagnosis.diagnosisID}, {diagnosisAnalysis.analysis.analysisID})";
                DB.Run(query);
            }
            catch
            {
                isDiagnosisAnalysisAdded = false;
            }
            DB.Close();
            return isDiagnosisAnalysisAdded;
        }

        /// <summary>
        /// Delete current DiagnosisAnalysis
        /// </summary>
        /// <param name="diagnosisAnalysis"></param>
        /// <returns></returns>
        public bool DeleteReservation(DiagnosisAnalysis diagnosisAnalysis)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isDiagnosisAnalysisDeleted = true;

            try
            {
                string query = $"delete from diagnosis_analysis where {DIAGNOSISC}={diagnosisAnalysis.diagnosis.diagnosisID} and {ANALYSISC}={diagnosisAnalysis.analysis.analysisID}";
                DB.Run(query);
            }
            catch
            {
                isDiagnosisAnalysisDeleted = false;
            }
            DB.Close();
            return isDiagnosisAnalysisDeleted;
        }
    }
}
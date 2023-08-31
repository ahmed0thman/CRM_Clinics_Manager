using System;
using System.Collections.Generic;
using System.Data;
using MySqlControl;
using static Clinic.BL.Analysis;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class AnalysisRepository
    {
        /// <summary>
        /// Retrieve one Analysis using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Patient</returns>
        public Analysis RetriveOneAnalysis(int id)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from analysis where {IDANALC}={id}";
            var tbl = DB.GetData(query);
            var analysis = new Analysis(id)
            {
                analysisName = tbl.Rows[0][$"{NAMEANALC}"].ToString()
            };
            DB.Close();
            return analysis;
        }

        /// <summary>
        /// Retrive all Analysis data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllAnalysis()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from analysis";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;
        }

        public List<Analysis> RetriveAllAnalysises()
        {
            // Code to get required Ray
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from analysis";
            var tbl = DB.GetData(query);
            List<Analysis> analysis = new List<Analysis>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                var anal = new Analysis  
                {
                    analysisID = int.Parse(tbl.Rows[i][$"{IDANALC}"].ToString()),
                    analysisName = tbl.Rows[i][$"{NAMEANALC}"].ToString()
                };
                analysis.Add(anal);
            }

            DB.Close();
            return analysis;
        }
        /// <summary>
        /// Adding new analysis
        /// </summary>
        /// <param name="analysis"></param>
        /// <returns></returns>
        public bool AddAnalysis(Analysis analysis)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isAnalysisAdded = true;

            try
            {
                string query = $"insert into analysis({NAMEANALC}) " +
                    $"values('{analysis}')";
                DB.Run(query);
            }
            catch
            {
                isAnalysisAdded = false;
            }
            DB.Close();
            return isAnalysisAdded;
        }

        /// <summary>
        /// Delete current analysis
        /// </summary>
        /// <param name="analysis"></param>
        /// <returns></returns>
        public bool DeleteAnalysis(string id)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isAnalysisDeleted = true;

            try
            {
                string query = $"delete from analysis where {IDANALC}={id}";
                DB.Run(query);
            }
            catch
            {
                isAnalysisDeleted = false;
            }
            DB.Close();
            return isAnalysisDeleted;
        }

        /// <summary>
        /// Edit the current analysis new data
        /// </summary>
        /// <param name="analysis"></param>
        /// <returns></returns>
        public bool SavePatient(Analysis analysis)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isAnalysisSaved = true;

            try
            {
                string query = $"updae analysis set {NAMEANALC}='{analysis}' where " +
                    $"{IDANALC} = {analysis.analysisID}";
                DB.Run(query);
            }
            catch
            {
                isAnalysisSaved = false;
            }
            DB.Close();
            return isAnalysisSaved;
        }
    }
}

using Clinic.Common;

namespace Clinic.BL
{
    public class Analysis : EntityBase, ILoggable
    {
        #region Constructors
        public Analysis() { }

        public Analysis(int? analysisID)
        {
            this.analysisID = analysisID;
        }

        public Analysis(int? analysisID, string analysisName)
            : this(analysisID)
        {
            this.analysisName = analysisName;
        }
        #endregion

        #region Fields and properities
        public int? analysisID { get; set; }
        public string analysisName { get; set; }
        #endregion

        #region Fields in database
        public static string IDANALC { get; set; } = "id";
        public static string NAMEANALC { get; set; } = "name";
        #endregion

        #region Methods
        /// <summary>
        /// Return analysis name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{analysisName}";

        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (analysisID == null) isValidUser = false;
            if (analysisName == null) isValidUser = false;
            
            return isValidUser;
        }

        public string Log() => $"Analysis ID :{analysisID}, Analysis Name: {analysisName}";
        #endregion
    }
}

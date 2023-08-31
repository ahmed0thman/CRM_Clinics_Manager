using Clinic.Common;

namespace Clinic.BL
{
    public class Ray : EntityBase, ILoggable
    {
        #region Constructors
        public Ray() { }

        public Ray(int rayID)
        {
            this.rayID = rayID;
        }

        public Ray(int rayID, string rayName)
            :this(rayID)
        {
            this.rayName = rayName;
        }
        #endregion

        #region Fields and properities
        public int? rayID { get; set; }
        public string rayName { get; set; }
        #endregion

        #region Fields in database
        public static string IDRAYC { get; set; } = "id";
        public static string NAMERAYC { get; set; } = "name";
        #endregion

        #region Methods
        /// <summary>
        /// Ray Name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{rayName}";

        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidUser = true;

            if (rayID == null) isValidUser = false;
            if (rayName == null) isValidUser = false;

            return isValidUser;
        }

        public string Log() => $"Ray ID :{rayID}, Ray name: {rayName}";
        #endregion
    }
}

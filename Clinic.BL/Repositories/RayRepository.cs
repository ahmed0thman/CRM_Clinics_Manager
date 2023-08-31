using System.Collections.Generic;
using MySqlControl;
using System.Data;
using static Clinic.BL.Ray;
using System.Data.Common;
using System.IO;
using System;
using static Clinic.BL.ConnectionString;


namespace Clinic.BL
{
    public class RayRepository
    {
        public Ray RetriveOneRay(int id)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from ray where {IDRAYC}={id}";
            var tbl = DB.GetData(query);
            var ray = new Ray
            {

                rayID = id,
                rayName = tbl.Rows[0][$"{NAMERAYC}"].ToString()
            };
            DB.Close();
            return ray;
        }
        /// <summary>
        /// Retrive all Rays data in Lst<Ray>
        /// </summary>
        /// <returns></returns>
        public List<Ray> RetriveAllRay()
        {
            // Code to get required Ray
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from ray";
            var tbl = DB.GetData(query);
            List<Ray> rays = new List<Ray>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                var ray = new Ray
                {
                    rayID = int.Parse(tbl.Rows[i][$"{IDRAYC}"].ToString()),
                    rayName = tbl.Rows[i][$"{NAMERAYC}"].ToString()
                };
                rays.Add(ray);
            }
            
            DB.Close();
            return rays;
        }

        /// <summary>
        /// Retrive all Rays data in DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllRays()
        {
            // Code to get required Ray
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from ray";
            var tbl = DB.GetData(query);
            
            DB.Close();
            return tbl;
        }

        /// <summary>
        /// Adding new Ray
        /// </summary>
        /// <param name="Ray"></param>
        /// <returns></returns>
        public bool AddRay(Ray ray)
        {
            bool iSRayAdded = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to add data
                // ..
                string query = $"insert into ray(" +
                   $"{NAMERAYC})" +
                   $" VALUES(" +
                   $"'{ray.rayName}')";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSRayAdded = false;
                throw (ex);
            }
            DB.Close();
            return iSRayAdded;
        }

        /// <summary>
        /// Delete current Ray
        /// </summary>
        /// <param name="Ray"></param>
        /// <returns></returns>
        public bool DeleteRay(string id)
        {
            bool isRayDeleted = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to delete data
                // ..
                string query = $" delete from ray where {IDRAYC} = {id}";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                isRayDeleted = false;
                throw (ex);
            }
            DB.Close();

            return isRayDeleted;
        }

        /// <summary>
        /// Save the current Ray new data
        /// </summary>
        /// <returns></returns>
        public bool SaveRay(Ray ray)
        {
            bool isRaySaved = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to save data
                // ..
                string query = $"update ray set  {NAMERAYC}='{ray.rayName}" +
               $" where {IDRAYC}={ray.rayID}";

                DB.Run(query);

            }
            catch (Exception ex)
            {
                isRaySaved = false;
                throw (ex);
            }
            DB.Close();

            return isRaySaved;
        }
    }
}

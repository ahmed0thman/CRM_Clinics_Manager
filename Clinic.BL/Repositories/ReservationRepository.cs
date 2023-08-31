using System.Collections.Generic;
using MySqlControl;
using System.Data;
using static Clinic.BL.Reservation;
using static Clinic.BL.Patient;
using static Clinic.BL.ConnectionString;
using System.Data.Common;
using System.IO;
using System;
using System.Runtime.InteropServices;

namespace Clinic.BL
{
    public class ReservationRepository
    {
        /// <summary>
        /// Retrieve one Reservation
        /// </summary>
        /// <param name="patientID"></param>
        /// <param name="doctorID"></param>
        /// <param name="ReservationDate"></param>
        /// <param name="ReservationQueue"></param>
        /// <returns></returns>
        public bool RetriveOneReservation(int patientID)
        {
            // Code to get required reservation
            // ..
            bool Valid = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from reservation where {IDPATIENTRESC}={patientID}";
            var tbl = DB.GetData(query);
            if (tbl.Rows.Count > 0)
                Valid = false;
            DB.Close();


            return Valid;
        }

        /// <summary>
        /// Retrive all Reservations data
        /// </summary>
        /// <returns></returns>
        public List<Reservation> RetriveAllReservations(string date, bool holded = false)
        {
            // Code to get required reservation
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                List<Reservation> Reservations = new List<Reservation>();
                string holdedQuery = $" and {PATIENTQUEUEC} > 0 order by reservation.{PATIENTQUEUEC} asc";
                if(holded)
                    holdedQuery = $" and {PATIENTQUEUEC} < 0 order by reservation.{PATIENTQUEUEC} desc";
                string query = $"select reservation.{IDPATIENTRESC} as {IDPATIENTRESC}, patient.{NAMEC} as {NAMEC}," +
                    $" reservation.{PATIENTQUEUEC} as {PATIENTQUEUEC}" +
                    $" from reservation inner join patient" +
                    $" on reservation.{IDPATIENTRESC} = patient.{IDC}" +
                    $" where reservation.{PATIENTDATEC} = '{date}' {holdedQuery} ";
                DataTable tbl = DB.GetData(query);
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    Reservation reservation = new Reservation()
                    {
                        patient = new Patient(int.Parse(tbl.Rows[i][IDPATIENTRESC].ToString()), tbl.Rows[i][NAMEC].ToString()),
                        reservationQueue = int.Parse(tbl.Rows[i][PATIENTQUEUEC].ToString())
                    };
                    Reservations.Add(reservation);
                }
                DB.Close();
                return Reservations;
            }
            catch (Exception)
            {
                DB.Close();
                throw;
            }
            
        }

        public DataTable RetriveAllReservations(string date)
        {
            // Code to get required reservation
            // ..
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                string holdedQuery = $" and {PATIENTQUEUEC} > 0 order by reservation.{PATIENTQUEUEC} asc";
                string query = $"select patient.{NAMEC} as {NAMEC}, patient.{PHONEC} as {PHONEC}" +
                    $" from reservation inner join patient" +
                    $" on reservation.{IDPATIENTRESC} = patient.{IDC}" +
                    $" where reservation.{PATIENTDATEC} = '{date}' {holdedQuery} ";
                DataTable tbl = DB.GetData(query);
                
                DB.Close();
                return tbl;
            }
            catch (Exception)
            {
                DB.Close();
                throw;
            }

        }

        /// <summary>
        /// Adding new Reservation
        /// </summary>
        /// <param name="Reservation"></param>
        /// <returns></returns>
        public bool AddReservation(Reservation reservation)
        {
            bool iSReservationAdded = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to add data
                // ..
                string query = $"insert into reservation(" +
                                       $"{IDPATIENTRESC}, {PATIENTDATEC},{PATIENTQUEUEC})" +
                                       $" VALUES(" +
                                       $"{reservation.patient.patientID},'{reservation.reservationDate}',{reservation.reservationQueue})";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSReservationAdded = false;
                throw (ex);
            }
            DB.Close();

            return iSReservationAdded;
        }
        public bool updateReservation(Reservation reservation)
        {
            bool iSReservationAdded = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to add update
                // ..
                string query = $"update reservation set " +
                                       $"{PATIENTDATEC} = '{reservation.reservationDate}'" +
                                       $",{PATIENTQUEUEC} = {reservation.reservationQueue}" +
                                       $" where {IDPATIENTRESC} = '{reservation.patient.patientID}'";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSReservationAdded = false;
                throw (ex);
            }
            DB.Close();

            return iSReservationAdded;
        }


        public bool HoldReservation(Reservation reservation)
        {
            bool iSReservationAdded = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to add update
                // ..
                string query = $"update reservation set " +
                                       $"{PATIENTQUEUEC} = {PATIENTQUEUEC} * -1" +
                                       $" where {IDPATIENTRESC} = '{reservation.patient.patientID}'";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSReservationAdded = false;
                throw (ex);
            }
            DB.Close();

            return iSReservationAdded;
        }

        /// <summary>
        /// Delete current Reservation
        /// </summary>
        /// <param name="Reservation"></param>
        /// <returns></returns>
        public bool DeleteReservation(Reservation reservation)
        {
            bool iSReservationDeleted = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to delete data
                // ..
                string query = $" delete from reservation where {IDPATIENTRESC} = {reservation.patient.patientID}";
                DB.Run(query);

            }
            catch (Exception ex)
            {
                iSReservationDeleted = false;
                throw (ex);
            }
            DB.Close();
            return iSReservationDeleted;
        }

        /// <summary>
        /// Save the current Reservation new data
        /// </summary>
        /// <returns></returns>
        public bool SaveReservation(Reservation reservation)
        {
            bool iSReservationSaved = true;
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                // Code to save data
                // ..
                string query = $"update reservation set {PATIENTDATEC}='{reservation.reservationDate}'," +
                    $" {PATIENTQUEUEC}='{reservation.reservationQueue}', " +
                    $" where  {IDPATIENTRESC}={reservation.patient}";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSReservationSaved = false;
                throw (ex);
            }
            DB.Close();

            return iSReservationSaved;
        }
        public int GetLastQueueInDate(string dt)
        {
            var DB = new MySqlClass(ConnStr);
            int id = -1;

            DB.Open();
            try
            {
                string query = $"select max({PATIENTQUEUEC}) as {PATIENTQUEUEC} from reservation where {PATIENTDATEC} = '{dt}'";
                var tbl = DB.GetData(query);
                id = int.Parse(tbl.Rows[0][PATIENTQUEUEC].ToString());
                DB.Close();
                return id;
            }
            catch (Exception)
            {
                DB.Close();
                return id;
            }

        }
        public int CountReservations(string dt)
        {
            var DB = new MySqlClass(ConnStr);
            int id = -1;

            DB.Open();
            try
            {
                string query = $"select count({PATIENTQUEUEC}) as {PATIENTQUEUEC} from reservation where {PATIENTDATEC} = '{dt}'";
                var tbl = DB.GetData(query);
                id = int.Parse(tbl.Rows[0][PATIENTQUEUEC].ToString());
                DB.Close();
                return id;
            }
            catch (Exception)
            {
                DB.Close();
                return id;
            }
        }

        public void SwitchReservations(Reservation res1, Reservation res2, string dt)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            try
            {
                string query1 = $"update reservation set " +
                    $" {PATIENTQUEUEC}='{res2.reservationQueue}' " +
                    $" where  {IDPATIENTRESC}={res1.patient.patientID} and {PATIENTDATEC} = '{dt}'";
                DB.Run(query1);
                string query2 = $"update reservation set " +
                    $" {PATIENTQUEUEC}='{res1.reservationQueue}' " +
                    $" where  {IDPATIENTRESC}={res2.patient.patientID} and {PATIENTDATEC} = '{dt}'";
                DB.Run(query2);
                DB.Close();

            }
            catch (Exception)
            {
                DB.Close();
                throw;
            }
        }
    }
}

using System.Collections.Generic;
using MySqlControl;
using System.Data;
using static Clinic.BL.Person;
using System.Data.Common;
using System.IO;
using System;
using static Clinic.BL.ConnectionString;

namespace Clinic.BL
{
    public class PersonRepository
    {
        public PersonType GetPersonType(string strType)
        {
            if (strType == "Doctor")
            {
                return PersonType.Doctor;
            }
            return PersonType.Secritary;
        }

        /// <summary>
        /// Retrieve one Person using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Person</returns>
        public Person RetriveOnePerson(int id)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from person where {PERSONIDC}={id}";
            var tbl = DB.GetData(query);

            PersonType personType = GetPersonType(tbl.Rows[0][PERSONTYPEC].ToString());
            var person = new Person(id)
            {
                personName = tbl.Rows[0][$"{PERSONNAMEC}"].ToString(),
                personPhone = tbl.Rows[0][$"{PERSONPHONEC}"].ToString(),
                personUsername = tbl.Rows[0][$"{PERSONUSERNAMEC}"].ToString(),
                personPassword = tbl.Rows[0][$"{PERSONPASSC}"].ToString(),
                personEmail = tbl.Rows[0][$"{PERSONMAILC}"].ToString(),
                personAddress = tbl.Rows[0][$"{PERSONADDRESSC}"].ToString(),
                personType = personType
            };
            DB.Close();
            return person;
        }

        /// <summary>
        /// Retrieve one Person using username and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Person RetriveOnePerson(string username, string password)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from person where {PERSONUSERNAMEC}='{username}' and {PERSONPASSC}='{password}'";
            var tbl = DB.GetData(query);

            if (tbl.Rows.Count == 0)
                return null;

            PersonType personType = GetPersonType(tbl.Rows[0][PERSONTYPEC].ToString());
            var person = new Person()
            {
                personID = int.Parse(tbl.Rows[0][$"{PERSONIDC}"].ToString()),
                personName = tbl.Rows[0][$"{PERSONNAMEC}"].ToString(),
                personPhone = tbl.Rows[0][$"{PERSONPHONEC}"].ToString(),
                personUsername = username,
                personPassword = password,
                personEmail = tbl.Rows[0][$"{PERSONMAILC}"].ToString(),
                personAddress = tbl.Rows[0][$"{PERSONADDRESSC}"].ToString(),
                personType = personType
            };
            DB.Close();
            return person;
        }

        /// <summary>
        /// Retrive all Persons data
        /// </summary>
        /// <returns></returns>
        public DataTable RetriveAllPersons()
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            string query = $"select * from person";
            var tbl = DB.GetData(query);
            DB.Close();
            return tbl;
        }

        /// <summary>
        /// Adding new Person
        /// </summary>
        /// <param name="Person"></param>
        /// <returns></returns>
        public string AddPerson(Person person)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool iSPersonAdded = true;
            string state = "Done";

            try
            {
                string query = $"insert into person(" +
                   $"{PERSONIDC}, {PERSONNAMEC}, {PERSONPHONEC}, {PERSONUSERNAMEC}, {PERSONPASSC}, {PERSONMAILC}, {PERSONADDRESSC}, {PERSONTYPEC})" +
                   $" VALUES(" +
                   $"{person.personID}, '{person.personName}', '{person.personPhone}', '{person.personUsername}', '{person.personPassword}', " +
                   $"'{person.personEmail}', '{person.personAddress}', '{person.personType}')";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                iSPersonAdded = false;
                state = ex.Message;
            }

            return state;
        }

        /// <summary>
        /// Delete current Person
        /// </summary>
        /// <param name="Person"></param>
        /// <returns>bool</returns>
        public string DeletePerson(int id)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isPersonDeleted = true;
            string state = "Done";

            try
            {
                // Code to delete data
                // ..
                string query = $" delete from person where {PERSONIDC} = {id}";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                isPersonDeleted = false;
                state = ex.Message;
            }
            DB.Close();
            return state;
        }

        /// <summary>
        /// Edit the current Person new data
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public string SavePerson(Person person)
        {
            var DB = new MySqlClass(ConnStr);
            DB.Open();
            bool isPersonSaved = true;
            string state = "Done";

            try
            {
                string query = $"update person set {PERSONIDC}={person.personID}, {PERSONNAMEC}='{person.personName}', {PERSONPHONEC}='{person.personPhone}', " +
                     $"{PERSONUSERNAMEC}='{person.personUsername}', {PERSONPASSC}='{person.personPassword}', {PERSONMAILC}='{person.personEmail}', " +
                     $"{PERSONADDRESSC}='{person.personAddress}', {PERSONTYPEC}='{person.personType}' " +
                     $"where {PERSONIDC}={person.personID}";
                DB.Run(query);
            }
            catch (Exception ex)
            {
                state = ex.Message;
            }
            DB.Close();
            return state;
        }
    }
}

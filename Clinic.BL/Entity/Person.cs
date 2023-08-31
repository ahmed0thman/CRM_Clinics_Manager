using Clinic.Common;

namespace Clinic.BL
{
    public enum PersonType
    {
        Doctor,
        Secritary
    }

    public class Person : EntityBase, ILoggable
    {
        #region Constructors
        public Person() { }

        public Person(int personID)
        {
            this.personID = personID;
        }

        public Person(int personID, string personPhone)
            : this(personID)
        {
            this.personPhone = personPhone;
        }

        public Person(int personID, string personPhone, string personName)
            : this(personID, personPhone)
        {
            this.personName = personName;
        }

        public Person(int personID, string personPhone, string personName, string personEmail)
            : this(personID, personPhone, personName)
        {
            this.personEmail = personEmail;
        }

        public Person(int personID, string personPhone, string personName, string personEmail, string personUsername)
            : this(personID, personPhone, personName, personEmail)
        {
            this.personUsername = personUsername;
        }

        public Person(int personID, string personPhone, string personName, string personEmail, string personUsername, string personPassword)
            : this(personID, personPhone, personName, personEmail, personUsername)
        {
            this.personPassword = personPassword;
        }

        public Person(int personID, string personPhone, string personName, string personEmail, string personUsername, string personPassword, string personAddress)
            :this(personID, personPhone, personName, personEmail, personUsername, personPassword)
        {
            this.personAddress = personAddress;
        }

        public Person(int personID, string personPhone, string personName, string personEmail, string personUsername, string personPassword, string personAddress, PersonType personType)
            :this(personID, personPhone, personName, personEmail, personUsername, personPassword, personAddress)
        {
            this.personType = personType;
        }
        #endregion

        #region Fields and properities
        public int personID { get; set; }
        public string personName { get; set; }
        public string personPhone { get; set; }
        public string personUsername { get; set; }
        public string personPassword { get; set; }
        public string personEmail { get; set; }
        public string personAddress { get; set; }
        public PersonType personType { get; set; }
        #endregion

        #region Fields in database
        public static string PERSONIDC { get; set; } = "id";
        public static string PERSONNAMEC { get; set; } = "name";
        public static string PERSONPHONEC { get; set; } = "phone";
        public static string PERSONUSERNAMEC { get; set; } = "username";
        public static string PERSONPASSC { get; set; } = "pass";
        public static string PERSONMAILC { get; set; } = "e_mail";
        public static string PERSONADDRESSC { get; set; } = "address";
        public static string PERSONTYPEC { get; set; } = "type";
        #endregion

        #region Methods
        /// <summary>
        /// Validate the current data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValidperson = true;

            if (personName == null) isValidperson = false;
            if (personPhone == null) isValidperson = false;
            if (personEmail == null) isValidperson = false;
            if (personUsername == null) isValidperson = false;
            if (personPassword == null) isValidperson = false;

            return isValidperson;
        }

        public static PersonType GetPersonType(string stringPersonType)
        {
            PersonType personType = PersonType.Secritary;

            if (stringPersonType.Trim() == "Doctor")
                personType = PersonType.Doctor;
            return personType;
        }

        /// <summary>
        /// User name
        /// </summary>
        /// <returns></returns>
        public override string ToString() => personName;

        public string Log() => $"person ID:{personID}, person Name: {personName}, person Mobil: {personPhone}, person Email: {personEmail}, Username: {personUsername}, Password: {personPassword}";
        #endregion
    }
}
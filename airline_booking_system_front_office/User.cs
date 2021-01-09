using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airline_booking_system_front_office
{
    public class User
    {
        private String UserID;
        private String Email;
        private String Password;
        private String FirstName;
        private String Surnames;
        private String Country;
        private String City;
        private String PostalCode;

        public User(string userID, string email, string password, string firstName, string surnames, string country, string city, string postalCode)
        {
            UserID = userID;
            Email = email;
            Password = password;
            FirstName = firstName;
            Surnames = surnames;
            Country = country;
            City = city;
            PostalCode = postalCode;
        }
    }
}
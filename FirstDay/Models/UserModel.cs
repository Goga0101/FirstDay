using FirstDay.Enums;
using System.Net;
using System;

namespace FirstDay.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int Currency { get; set; }

        public Languages language { get; set; }

        public IPAddress RegistrationIp { get; set; }

        public int GenderId { get; set; }

        public string Country { get; set; }

        public DateTime DateOfbirth { get; set; }

        public string Nick { get; set; }

        public TimeZone TimeZone { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string AlternativePhone { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string AffiliateID { get; set; }

    }
}

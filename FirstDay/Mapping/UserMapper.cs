using FirstDay.Enums;
using FirstDay.Interfaces;
using MaxMind.GeoIP2.Model;
using System.Net;
using System.Xml.Linq;
using System;
using FirstDay.Models;

namespace FirstDay.Mapping
{
    public class UserMapper : IMapper<Poco.User, UserModel>
    {
        public UserModel MapFromEntityToModel(Poco.User source) => new UserModel
        {

            Id = source.Id,
            Login = source.Login,
            Password = source.Password,
            Currency = source.Currency,
            language = source.language,
            RegistrationIp = source.RegistrationIp,
            GenderId = source.GenderId,
            Country = source.Country,
            DateOfbirth = source.DateOfbirth,
            Nick = source.Nick,
            TimeZone = source.TimeZone,
            Name = source.Name,
            LastName = source.LastName,
            Phone = source.Phone,
            AlternativePhone = source.AlternativePhone,
            City = source.City,
            Address = source.Address,
            Email = source.Email,
            AffiliateID = source.AffiliateID,




        };

        public Poco.User MapFromModelToEntity(UserModel source)
        {
            var entity = new Poco.User();

            MapFromModelToEntity(source, entity);

            return entity;
        }

        public void MapFromModelToEntity(UserModel source, Poco.User target)
        {
            target.Id = source.Id;
            target.Login = source.Login;
            target.Password = source.Password;
            target.Currency = source.Currency;
            target.language = source.language;
            target.RegistrationIp = source.RegistrationIp;
            target.GenderId = source.GenderId;
            target.Country = source.Country;
            target.DateOfbirth = source.DateOfbirth;
            target.Nick = source.Nick;
            target.TimeZone = source.TimeZone;
            target.Name = source.Name;
            target.LastName = source.LastName;
            target.Phone = source.Phone;
            target.AlternativePhone = source.AlternativePhone;
            target.City = source.City;
            target.Address = source.Address;
            target.Email = source.Email;
            target.AffiliateID = source.AffiliateID;





        }


    }

}


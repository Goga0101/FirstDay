using FirstDay.Interfaces;
using FirstDay.Mapping;
using FirstDay.Models;
using FirstDay.Poco;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FirstDay.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly FirstDayContext _context;
        private readonly IMapper<Poco.User, UserModel> _userMapper;







        public UserRepository(FirstDayContext context)
        {
            _userMapper = new UserMapper();
            _context = context;
        }





        public CreateUserResponse CreateUser(UserModel user)
        {
            var userAlreadyExists = _context.Users.Any(u => u.Id == user.Id);

            if (userAlreadyExists)
            {
                throw new DbUpdateException($"User with id '{user.Id}' already exist.");
            }

            var record = _context.Users.Add(_userMapper.MapFromModelToEntity(user));

            _context.SaveChanges();

            return new CreateUserResponse { CreatedUser = _userMapper.MapFromEntityToModel(record.Entity) };

        }

        [HttpGet]

        public GetUserResponse GetUser(GetUserRequest getUserRequest)
        {
            var user = _context.Users.Find(getUserRequest.Id);

            return new GetUserResponse { User = _userMapper.MapFromEntityToModel(user) };
        }
    }
}

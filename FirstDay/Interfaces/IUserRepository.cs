using FirstDay.Models;
using FirstDay.Poco;

namespace FirstDay.Interfaces
{
    public interface IUserRepository
    {
        CreateUserResponse CreateUser(UserModel request);

        GetUserResponse GetUser(GetUserRequest request);
    }
}

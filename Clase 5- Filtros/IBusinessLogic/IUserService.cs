using Domain;

namespace IBusinessLogic;

public interface IUserService
{
    User AddUser(User user);
    User GetUsersById(int userId);
    User UpdateUser(User newUser, int userId);
    string Login(string email, string password);
    User GetUserByToken(string toString);
    
    
}
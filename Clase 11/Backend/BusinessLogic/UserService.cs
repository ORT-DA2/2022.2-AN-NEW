using Domain;
using IBusinessLogic;
using IDataAccess;

namespace BusinessLogic;

public class UserService : IUserService
{
    private IUserRepository _repository;
    private IGuidService _guidService;

    public UserService(IUserRepository vRepository, IGuidService vGuid)
    {
        _repository = vRepository;
        _guidService = vGuid;
    }

    public User AddUser(User admin)
    {
        _repository.Add(admin);
        return admin;
    }
        
    public User GetUsersById(int userId)
    {
        try
        {
            return _repository.Find(x => x.Id == userId);
        }
        catch (KeyNotFoundException)
        {
            throw new KeyNotFoundException();
        }
    }

    public User UpdateUser(User newUser, int userId)
    {
        User oldUser = GetUsersById(userId);
        return _repository.Update(oldUser, newUser);
    }

    public string Login(string email, string password)
    {
        try
        {
            User user = _repository.Find(
                x => x.Email == email && x.Password == password);
            user.Token = _guidService.NewGuid().ToString();
            UpdateUser(user, user.Id);
            return user.Token;
        }
        catch (KeyNotFoundException)
        {
            throw new KeyNotFoundException();
        }
    }

    public User GetUserByToken(string token)
    {
        try
        {
            return _repository.Find(x => x.Token == token);
        }
        catch (KeyNotFoundException)
        {
            throw new KeyNotFoundException();
        }
    }


}
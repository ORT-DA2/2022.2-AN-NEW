using Domain;
using IDataAccess;

namespace DataAccess;

public class UserRepository: IUserRepository
{
    private ContextDb _context;

    public UserRepository(ContextDb context)
    {
        _context = context;
    }
    
    public void Add(User entity)
    {
        _context.Users.Add(entity);
        _context.SaveChanges();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User Find(Predicate<User> condition)
    {
        List<User> adminsitrators = _context.Users.ToList();
        foreach (var user in adminsitrators)
        {
            var condResult = condition(user);
            if (condResult)
                return user;
        }
        throw new KeyNotFoundException();
    }
    
    private User FindDto(Predicate<User> condition)
    {
        List<User> adminsitrators = _context.Users.ToList();
        foreach (var user in adminsitrators)
        {
            var condResult = condition(user);
            if (condResult)
                return user;
        }
        throw new KeyNotFoundException();
    }


    public User Update(User oldObject, User updatedObject)
    {
        _context.Users.Update(updatedObject);
        _context.SaveChanges();
        return updatedObject;
    }
}
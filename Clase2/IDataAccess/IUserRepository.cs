using Domain;

namespace IDataAccess;

public interface IUserRepository
{
    void Add(User entity);
    List<User> GetAll();
    User Find(Predicate<User> condition);
    User Update(User oldObject, User updatedObject);
}
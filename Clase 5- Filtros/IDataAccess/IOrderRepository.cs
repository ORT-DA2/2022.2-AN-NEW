using Domain;

namespace IDataAccess;

public interface IOrderRepository
{
    void Add(Order entity);
    void Delete(Order entity);
    void Update(Order entity);
    IQueryable<Order> GetAll();
}
using Domain;
using System.Linq;

namespace IDataAccess;

public interface IOrderRepository
{
    Order Add(Order entity);
    void Delete(Order entity);
    void Update(Order entity);
    IQueryable<Order> GetAll();
    IQueryable<Order> GetFilteredOrders(Expression<Func<Order, bool>> expression);
    IQueryable<Order> GetAllNames(Expression<Func<Order, string>> expression);
}
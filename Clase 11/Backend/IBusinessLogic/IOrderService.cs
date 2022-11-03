using Domain;

namespace IBusinessLogic;

public interface IOrderService
{
    void Create(Order order);
    void Update(Order order);
    void Delete(Order order);
    IQueryable<Order> GetAll();

}
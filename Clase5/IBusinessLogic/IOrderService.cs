using Domain;

namespace IBusinessLogic;

public interface IOrderService
{
    Order Create(Order order);
    void Update(Order order);
    void Delete(Order order);
    IQueryable<Order> GetAll();

    IQueryable<Order> GetFilteredOrders(int year ,int priceLowerBound, int priceUpperBound);

    IQueryable<Order> GetAllNames();
}
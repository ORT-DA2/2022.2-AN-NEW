using Domain;
using IBusinessLogic;
using IDataAccess;

namespace BusinessLogic;

public class OrderService : IOrderService
{
    private IOrderRepository _repository;

    public OrderService(IOrderRepository orderRepository)
    {
        _repository = orderRepository;
    }
    
    public Order Create(Order order)
    {
        Order createdOrder = _repository.Add(order);
        return createdOrder;
    }

    public void Update(Order order)
    {
        throw new NotImplementedException();
    }

    public void Delete(Order order)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Order> GetAll()
    {
        return _repository.GetAll();
    }

    public IQueryable<Order> GetFilteredOrders(int year ,int priceLowerBound, int priceUpperBound)
    {
        Expression<Func<Order, bool>> expression = order => 
            order.DeliveryDateTime.Year == year && order.price >= priceLowerBound && order.price >= priceUpperBound;
        return _repository.GetFilteredOrders(expression);
    }

    public IQueryable<Order> GetAllNames()
	{
		Expression<Func<Order, string>> expression = order => order.Name;
		
		IQueryable<Order> orders = _orderRepository.GetAllNames(expression);
		
		return orders;
	}
}
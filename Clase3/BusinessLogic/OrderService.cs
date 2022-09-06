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
    
    public void Create(Order order)
    {
        _repository.Add(order);
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
}
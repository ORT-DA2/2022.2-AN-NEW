using Domain;
using IDataAccess;

namespace DataAccess;

public class OrderRepository: IOrderRepository
{
    private ContextDb _context;

    public OrderRepository(ContextDb context)
    {
        _context = context;
    }
    public void Add(Order entity)
    {
        _context.Orders.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(Order entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Order entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Order> GetAll()
    {
        return _context.Orders;
    }
}
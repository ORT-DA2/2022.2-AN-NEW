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
    public Order Add(Order entity)
    {
        _context.Orders.Add(entity);
        _context.SaveChanges();
        return entity;
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

    public IQueryable<Order> GetFilteredOrders(Expression<Func<Order, bool>> expression)
    {
        IEnumerable<Order> orders = _context.Orders.Where(expression);

        return orders;
    }

    public IQueryable<Order> GetAllNames(Expression<Func<Order, string>> expression)
    {
	    IQueryable<Order> orders = _context.Orders.Select(expression);
    
	    return orders;
    }
}
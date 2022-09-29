using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models.Out;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/Orders")]
public class OrderController : ControllerBase
{
    private IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        IQueryable<Order> orders = _orderService.GetAll();
        return Ok(orders);
    }

    [HttpPost]
    public IActionResult Add([FromBody] Order order)
    {
        try
        {
            Order createdOrder = _orderService.Create(order);
            return CreatedAtRoute("AddOrder", new OrderBasicInfoModel()
            {
                Id = createdOrder.Id,
                DeliveryDateTime = createdOrder.DeliveryDateTima
            });
        }
        catch (ArgumentException ex)
        {
            return BadRequest();
        }
    }
}
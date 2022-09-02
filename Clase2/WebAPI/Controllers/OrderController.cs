using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;

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
        _orderService.Create(order);
        return Created("", order);
    }
}
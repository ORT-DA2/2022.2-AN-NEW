using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Filters;

namespace WebAPI.Controllers;

[ApiController]
[ExceptionFilter]
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
    [ServiceFilter(typeof(FilterAuthentication))]
  //  [ProtectFilter(RoleType.Admin)]
    public IActionResult Add([FromBody] Order order)
    {
        _orderService.Create(order);
        return Created("", order);
    }
}
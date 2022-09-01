using Microsoft.AspNetCore.Mvc;
using Tacos.WebApi.Controllers.In;
using Tacos.WebApi.Controllers.Out;

namespace Tacos.WebApi.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController: ControllerBase
{
    [HttpGet]
    public IActionResult Get(){
        return Ok();
    }

    // api/orders?day='15-08-2022'
    [HttpGet]
    public IActionResult GetBy([FromQuery] string day){
        return Ok();
    }

    // api/orders/2
    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] int id){
        return Ok(new OrderBasicInfoModel()
            {
                Id = 1,
                Table = 2
            }
        );
    }

    //api/orders
    [HttpPost]
    public IActionResult Post([FromBody] OrderIntentModel order){
        return Ok();
    }

    //api/orders/2
    [HttpPut("{id}")]
    public IActionResult Put([FromRoute] int id,[FromBody] OrderIntentModel order){
        return Ok();
    }

    //api/orders/2
    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id){
        return Ok();
    }

    //api/orders
    [HttpDelete]
    public IActionResult Delete(){
        return Ok();
    }
}
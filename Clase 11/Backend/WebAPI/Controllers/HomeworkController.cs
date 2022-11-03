using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using WebAPI.Filters;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/homeworks")]
[FilterExceptions]
public class HomeworkController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        List<Homework> returnedHomeworks = new List<Homework>()
        {
            new Homework() 
            {
                Id = 1,
                Description = "Una tarea",
                DueDate = new DateTime(),
                Score = 2,
                Rating = 3,
                exercises = new List<Exercise>()
                {
                    new Exercise() 
                    {
                        Id = 1,
                        Problem = "Un Problema",
                        Score = 2        
                    }
                }
            },
            new Homework() 
            {
                Id = 2,
                Description = "Otra tarea",
                DueDate = new DateTime(),
                Score = 3,
                Rating = 5,
                exercises = new List<Exercise>()
                {
                    new Exercise() 
                    {
                        Id = 2,
                        Problem = "Otro Problema",
                        Score = 5       
                    }
                }
            }
        };
        return Ok(returnedHomeworks);
    }
}
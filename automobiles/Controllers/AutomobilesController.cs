using Microsoft.AspNetCore.Mvc;
using automobiles.Models;
using automobiles.Data;
using System.Linq;

namespace automobiles.Controllers;

[ApiController]
[Route("[controller]")]
public class AutomobilesController : ControllerBase
{
 
    private  readonly List<Car> Cars =
[
    new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020 },
    new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2019 },
    new Car { Id = 3, Make = "Ford", Model = "Mustang", Year = 2021 },
    new Car { Id = 4, Make = "Chevrolet", Model = "Malibu", Year = 2018 },
    new Car { Id = 5, Make = "Nissan", Model = "Altima", Year = 2022 }
];


    private readonly ILogger<AutomobilesController> _logger;

    public AutomobilesController(ILogger<AutomobilesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Automobile> Get()
    {
        using var context = new AutomobileContext();
        var f =  context.Automobiles.All(a => true);
        return context.Automobiles.ToList();
    }
     [HttpGet("{id}", Name = "GetCar")] 
    public Car Get(int id)
    {
        return this.Cars.FirstOrDefault(car => car.Id == id);
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BasicCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicCalculatorController : ControllerBase
{
    [HttpGet]
    public int Add(int a, int b)
    {
        return a + b;
    }
}

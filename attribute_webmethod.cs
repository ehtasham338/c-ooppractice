using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MyController : ControllerBase
{
    [HttpGet("greet")]
    public string Greet(string name)
    {
        return "Hello, " + name + "!";
    }
}

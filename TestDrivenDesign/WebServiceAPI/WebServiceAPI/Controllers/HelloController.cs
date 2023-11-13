using Microsoft.AspNetCore.Mvc;

namespace WebServiceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Hello")]
    public string Hello()
    {
        return "Hello";
    }

    [HttpGet("{Who}", Name = "Hello")]
    public string Get(string Who)
    {
        return string.IsNullOrEmpty(Who) ? "Hello Mario" : Who;
    }
}
using Microsoft.AspNetCore.Mvc;

namespace WebServiceAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class RecipeController : ControllerBase
{
    private readonly ILogger<RecipeController> _logger;

    public RecipeController(ILogger<RecipeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Hello")]
    public string Hello()
    {
        return "Hello";
    }

    [HttpGet("{Who}", Name = "Hello")]
    public string GetMario(string Who)
    {
        return Who.Equals("Mario") ? "Hello Mario" : Who;
    }

    [HttpGet("GetDishes")]
    public string[] GetDishes()
    {
        string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings" };
        return dishes;
    }

    [HttpGet("GetRecipes")]
    public ActionResult GetRecipes()
    {
        var recipes = new []{ "Oxtail", "Curry Chicken", "Dumplings" };
    
        if (!recipes.Any()) return NotFound();
        return Ok(recipes);
    }

    // [HttpPost]
    // public ActionResult CreateNewRecipe()
    // {
    //     return null;
    // }

    [HttpDelete]
    public ActionResult DeleteRecipes()
    {
        var somethingBadHappened = false;

        if (somethingBadHappened) return BadRequest();

        return NoContent();
    }
}
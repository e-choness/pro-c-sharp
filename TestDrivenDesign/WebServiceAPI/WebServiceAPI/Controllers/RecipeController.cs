using Microsoft.AspNetCore.Mvc;
using WebServiceAPI.Models;

namespace WebServiceAPI.Controllers;

[Route("api/[controller]")]
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
    public ActionResult GetRecipes([FromQuery]int count)
    {
        Recipe[] recipes =
        {
            new(){Title="Oxtail"}, 
            new(){Title="Curry Chicken"},
            new(){Title="Dumplings"}
        };
    
        if (!recipes.Any()) return NotFound();
        
        // Sanity check
        if (count > recipes.Length) count = recipes.Length;
        
        return Ok(recipes.Take(count));
    }

    [HttpPost("CreateRecipe")]
    public ActionResult CreateNewRecipe([FromBody] Recipe newRecipe)
    {
        bool somethingBadHappened = false;
        if (somethingBadHappened) return BadRequest();

        return Created("", newRecipe);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteRecipes(long id)
    {// id get passed along here
        var somethingBadHappened = false;

        if (somethingBadHappened) return BadRequest();

        return NoContent();
    }
}
using WebServiceAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace WebServiceAPI.Services;

public class RecipeService
{
    private readonly IMongoCollection<Recipe> _recipeCollection;
}
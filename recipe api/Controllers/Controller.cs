using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using recipe_api.Clients;

namespace recipe_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly ILogger<Controller> _logger;
        public RecipeClients (ILogger<Controller> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public GetRecipe(string name, string id)
        {
            GetRecipe client = new GetRecipeClient();
            return client.GetRecipeAsync(name, id).Result;
        }
    }
}
    
}

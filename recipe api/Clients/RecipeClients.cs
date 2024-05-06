using recipe_api.Models;
using System.Reflection.PortableExecutable;

namespace recipe_api.Clients
{
    public class RecipeClients
    {
        
        private static string _address;
        private static string _apikey;
        private static string _apiHost;

        public RecipeClients()
        {

            _address = Constants.Address;
            _apikey = Constants.Apikey;
            _apiHost = Constants.ApiHost;
        }
    }
    public async Task<RecipeDetails> GetRecipe(string q, string id, string ingredients, string recipeName, string matches, string attribution, string name)
    {
        //var responce = _client.GetAsync($"/v1/api/recipes?_app_id=app-id&_app_key=app-key&your _search_parameters");
        //var content = responce.Content.ReadAsStringAsync().Result;
        //var result = JsonConvert.DeserializeObject<recipe>(content);
        //return result;
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();
            {
                Method = HttpMethod.Get;
                RequestUri = new Uri(_adress);
        
        //        Headers =


        //{
                       { "X-RapidAPI-Key",  "e56ef14007msh822f112287fe201p1a7360jsneac7d8b0cf3c" },
                    { "X-RapidAPI-Host",  "yummly2.p.rapidapi.com"}
              }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                Console.WriteLine(body);
            }
        }
    }
}

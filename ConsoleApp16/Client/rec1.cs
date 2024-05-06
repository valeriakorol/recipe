using System;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ConsoleApp16.model;



namespace ConsoleApp16.Client
{
    internal class RecipeClients

    {
        private static string _address;
        private static string _apikey;
        private HttpClient _client;

        public RecipeClients()
        {

            _address = Constants.Address;
            _apikey = Constants.Apikey;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_address);
        }
    }
    public async Task<recipe> GetRecipeByName(string q, string id, string ingredients, string recipeName, string matches, string attribution, string name)
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
                RequestUri = new Uri($"https://yummly2.p.rapidapi.com/feeds/auto-complete?q={name}"),
        
                Headers = { 


                {
                    { "X-RapidAPI-Key",  "e56ef14007msh822f112287fe201p1a7360jsneac7d8b0cf3c" },
                    { "X-RapidAPI-Host",  "yummly2.p.rapidapi.com"},
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                return result;
            }
        }
    }
}
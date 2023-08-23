using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi
{
    public class SingletonHttp : ISingletonHttp
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _iconfiguration;

        public SingletonHttp(HttpClient client, IConfiguration iconfiguration)
        {
            _client = client;
            _iconfiguration = iconfiguration;
        }
        public async Task<List<Country>> GetServices()
        {
            try
            {
                string query = _iconfiguration.GetSection("ApiUrls").GetSection("CountryUrls").Value;
                using HttpResponseMessage response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<Country>>(responseBody);
                    return data;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

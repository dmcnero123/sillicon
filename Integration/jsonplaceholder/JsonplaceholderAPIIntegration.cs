using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sillicon.Integration.jsonplaceholder.User;

namespace sillicon.Integration.jsonplaceholder
{
    public class JsonplaceholderApiIntegration
    {
        private readonly ILogger<JsonplaceholderApiIntegration> _logger;
        private const string API_URL="https://reqres.in/api/users";

        public JsonplaceholderApiIntegration(ILogger<JsonplaceholderApiIntegration> logger){
            _logger=logger;
        }
        public async Task<List<Usuarioss>> GetAll(){
            string requestUrl = $"{API_URL}";
            List<Usuarioss> listTodos = new List<Usuarioss>();
            using (HttpClient client = new HttpClient())
            {
                try{
                    HttpResponseMessage response = await client.GetAsync(requestUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        listTodos =  await response.Content.ReadFromJsonAsync<List<Usuarioss>>() ??
                                        new List<Usuarioss>();
                    }
                }catch (HttpRequestException ex)
                {
                    _logger.LogDebug($"Error al llamar a la API: {ex.Message}");
                }
            }
            return listTodos;
        }
    }
}
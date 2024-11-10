using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UBDesktop.Models;

namespace UBDesktop.API
{
    public class APIService
    {
        private readonly HttpClient client;
        private string token;
        private readonly string baseUrl = "http://localhost:5173/api/"; //URL base

        public APIService()
        {
            client = new HttpClient();
        }

        public void SetToken(string jwtToken)
        {
            token = jwtToken;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var url = $"{baseUrl}Login/login";
            var loginData = new { nomeUsuario = username, senha = password };
            var content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(jsonResponse);
                return result.token;
            }

            return null;
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var url = $"{baseUrl}{endpoint}";

            var response = await client.GetAsync(url);
            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }

        public async Task<List<Pedido>> GetPedidosAsync()
        {
            var pedido = await GetAsync("Pedido/listarItens");
            return JsonConvert.DeserializeObject<List<Pedido>>(pedido);
        }
    }
}

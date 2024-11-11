using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var url = $"{baseUrl}Login";
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

        public async Task<bool> PostAsync(string endpoint, object data)
        {
            var url = $"{baseUrl}{endpoint}";
            var jsonData = JsonConvert.SerializeObject(data); 
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json"); 

            var response = await client.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }


        public async Task<List<Pedido>> GetPedidosAsync()
        {
            var pedido = await GetAsync("Pedido/listarItens");
            return JsonConvert.DeserializeObject<List<Pedido>>(pedido);
        }

        public async Task<List<GetFuncionariosResponse>> GetFuncionariosAsync()
        {
            var funcionario = await GetAsync("Login/usuarios");
            return JsonConvert.DeserializeObject<List<GetFuncionariosResponse>>(funcionario);
        }

        public async Task CreatePerfil(string nomeUsuario, string senha, string email, string role)
        {
            var novoFuncionario = new CreateFuncionarioRequest
            {
                NomeUsuario = nomeUsuario,
                Email = email,
                Senha = senha,
                Role = role
            };

            var success = await PostAsync("Login/registro", novoFuncionario);

            if (success)
            {
                MessageBox.Show("Perfil criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao criar o perfil.");
            }
        }
    }
}

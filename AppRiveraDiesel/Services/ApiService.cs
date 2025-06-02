using AppRiveraDiesel.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;
namespace AppRiveraDiesel.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://jbcprogramming.somee.com/")
            };
        }

        public async Task<bool> RegistrarUsuarioAsync(RegistroRequest request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Acceso/Registrarse", content);
            return response.IsSuccessStatusCode;
        }
    }
}

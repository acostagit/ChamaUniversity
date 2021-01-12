using Chama.Identidade.API.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chama.WebApp.MVC.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly HttpClient _httpCliente;
        public AutenticacaoService(HttpClient httpClient)
        {
            _httpCliente = httpClient;
        }
        public async Task<string> Login(UsuarioLogin usuarioLogin)
        {
            var url = "https://localhost:44309/api/identidade/autenticar";
            var loginContent = new StringContent(
                JsonSerializer.Serialize(usuarioLogin),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpCliente.PostAsync(url, loginContent);

            return JsonSerializer.Deserialize<string>(await response.Content.ReadAsStringAsync());
        }

        public async Task<string> Registro(UsuarioRegistro usuarioRegistro)
        {
            var url = "https://localhost:44309/api/identidade/nova-conta";
            var registroContent = new StringContent(
                JsonSerializer.Serialize(usuarioRegistro),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpCliente.PostAsync(url, registroContent);

            return JsonSerializer.Deserialize<string>(await response.Content.ReadAsStringAsync());
        }
    }
}

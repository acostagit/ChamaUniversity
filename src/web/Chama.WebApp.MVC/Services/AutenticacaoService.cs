using Chama.WebApp.MVC.Extensions;
using Chama.WebApp.MVC.Models;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chama.WebApp.MVC.Services
{
    public class AutenticacaoService : Service, IAutenticacaoService
    {
        private readonly HttpClient _httpClient;
        //private readonly AppSettings _settings;

        public AutenticacaoService(HttpClient httpClient, IOptions<AppSettings> settings)
        {
            httpClient.BaseAddress = new Uri(settings.Value.AutenticaURL);

            _httpClient = httpClient;
            //_settings = settings.Value;
        }
        
        public async Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin)
        {
            //var url = "https://localhost:44309/api/identidade/autenticar"; outra forma de fazer

            var loginContent = ObterConteudo(usuarioLogin);

            var response = await _httpClient.PostAsync("/api/identidade/autenticar", loginContent);
            //tbm pode ser eito desse jeito
            //var response = await _httpClient.PostAsync($"{_settings.AutenticaURL}/api/identidade/autenticar", loginContent);

            if (!TratarErrosResponse(response))
            {
                return new UsuarioRespostaLogin
                {
                    ResponseResult = await DeserializarObjetoResponse<ResponseResult>(response)
                };
            };

            return JsonSerializer.Deserialize<UsuarioRespostaLogin>(await response.Content.ReadAsStringAsync());
        }

        public async Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro)
        {
            //var url = "https://localhost:44309/api/identidade/nova-conta"; forma de fazer

            var registroContent = ObterConteudo(usuarioRegistro);

            var response = await _httpClient.PostAsync("/api/identidade/nova-conta", registroContent);
            //pode ser feito desse jeito
            //var response = await _httpClient.PostAsync($"{_settings.AutenticaURL}/api/identidade/nova-conta", registroContent);

            if (!TratarErrosResponse(response))
            {
                return new UsuarioRespostaLogin
                {
                    ResponseResult = await DeserializarObjetoResponse<ResponseResult>(response)
                };
            };

            return await DeserializarObjetoResponse<UsuarioRespostaLogin>(response);
        }
    }
}

using Chama.Identidade.API.Models;
using System.Threading.Tasks;

namespace Chama.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {    
        Task<string> Login(UsuarioLogin usuarioLogin);
        Task<string> Registro(UsuarioRegistro usuarioRegistro);
    }
}

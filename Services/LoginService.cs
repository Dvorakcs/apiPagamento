using apiPagamento.Models;
using apiPagamento.Repository;

namespace apiPagamento.Services
{
    public class LoginService
    {
        private readonly IUsuarioRespository usuarioRespository;
        public LoginService(IUsuarioRespository usuarioRespository)
        {
            this.usuarioRespository = usuarioRespository;
        }
        public Usuario GetUserForLogin(string email, string password)
        {
            return usuarioRespository.GetUserForLogin(email, password);
        }
    }
}

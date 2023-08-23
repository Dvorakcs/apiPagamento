using apiPagamento.Models;
using apiPagamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiPagamento.Controllers
{
    [ApiController]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        private readonly LoginService _login;

        public AuthenticationController(LoginService _login)
        {
            this._login = _login;
        }

        [HttpPost]
        public IActionResult Auth(string email, string password)
        {
            Usuario usuarioDb = this._login.GetUserForLogin(email, password);
            if (usuarioDb == null) return BadRequest("Usuario nao existe");


            var token = TokenService.GerarToken(usuarioDb);
            return Ok(token);


        }
    }
}

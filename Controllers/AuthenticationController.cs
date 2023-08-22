using apiPagamento.Models;
using apiPagamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiPagamento.Controllers
{
    [ApiController]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        private readonly UsuarioService _usuario;

        public AuthenticationController(UsuarioService _usuario)
        {
            this._usuario = _usuario;
        }

        [HttpPost]
        public IActionResult Auth(string email, string password)
        {
            Usuario usuarioDb = this._usuario.GetUserForLogin(email, password);
            if (usuarioDb == null) return BadRequest("Usuario nao existe");


            var token = TokenService.GerarToken(usuarioDb);
            return Ok(token);


        }
    }
}

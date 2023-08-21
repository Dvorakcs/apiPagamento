using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiPagamento.Context;
using apiPagamento.Models;
using apiPagamento.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace apiPagamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuario;

        public UsuarioController(UsuarioService _usuario)
        {
           this._usuario = _usuario;
        }

        [HttpGet]
        public IActionResult list(){

            return Ok(_usuario.GetUser());
        }

    }
}

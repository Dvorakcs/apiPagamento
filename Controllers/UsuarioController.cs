using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiPagamento.Context;
using apiPagamento.Models;

namespace apiPagamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly PagamentoContext _context;

        public UsuarioController(PagamentoContext context)
        {
            _context = context;
        }

    }
}

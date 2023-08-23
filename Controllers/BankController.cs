using apiPagamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiPagamento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : Controller
    {
        private readonly PagamentoService _pagamentoService;

        public BankController(PagamentoService _pagamentoService)
        {
            this._pagamentoService = _pagamentoService;
        }

        [HttpPost]
        public IActionResult TransferirDinheiro(int usuarioId,double Valor,string EmailRecebente)
        {
            return Ok(this._pagamentoService.EnviaPagamento(usuarioId, Valor,EmailRecebente));
        }

        [HttpPost("AdicionarCredito")]
        public IActionResult AdicionarCredito(int usuarioId, double Valor)
        {
            return Ok(this._pagamentoService.AdicionaCredito(usuarioId, Valor));
        }
    }
}

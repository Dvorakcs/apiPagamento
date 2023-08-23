using apiPagamento.Models;
using apiPagamento.Repository;

namespace apiPagamento.Services
{
    public class PagamentoService
    {
        private readonly ICaixaRepository _caixas;
        private readonly IUsuarioRespository _usuario;

        public PagamentoService(ICaixaRepository _caixas, IUsuarioRespository _usuario)
        {
            this._caixas = _caixas;
            this._usuario = _usuario;

        }
        public string EnviaPagamento(Usuario Usuario, double QuantidadeDinheiro,string EmailRecebente)
        {
            if (Usuario == null) return "Usuario Invalido";
            if (QuantidadeDinheiro == 0) return "Valor tem que Ser maior que 0";
            if (EmailRecebente == "") return "Insira um Email";

            Usuario usuarioDb = this._usuario.Get(Usuario.Id);
            if (usuarioDb == null) return "Usuario nao existe";

            Usuario usuarioRecebente = this._usuario.emailGetUser(EmailRecebente);
            if(usuarioRecebente == null) return "Usuario recebente nao existe ou Email inserido errado";


            Caixa caixa = this._caixas.Get(usuarioDb.Id);
            if (caixa == null) return "Usuario nao tem caixa criado";

            if (caixa.QuantidadeValorCaixa == 0 && 
                caixa.QuantidadeValorCaixa < QuantidadeDinheiro) return "Nao tem Saldo suficiente";


            Caixa caixaRecebente = this._caixas.Get(usuarioRecebente.Id);
            if (caixaRecebente == null) return "Usuario recebente nao tem caixa";

            caixa.QuantidadeValorCaixa -= QuantidadeDinheiro;
            caixaRecebente.QuantidadeValorCaixa += QuantidadeDinheiro;


            return "Transferencia Enviada";
        }
    }
}

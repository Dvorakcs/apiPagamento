using apiPagamento.Context;
using apiPagamento.Models;

namespace apiPagamento.Repository
{
    public class CaixaRepository : ICaixaRepository
    {
        private readonly PagamentoContext _context = new PagamentoContext();
        public void add(Caixa caixa)
        {
            this._context.caixas.Add(caixa);
            this._context.SaveChanges();
        }

        public void delete(Caixa caixa)
        {
            throw new NotImplementedException();
        }

        public Caixa Get(int idUsuario)
        {
           return this._context.caixas.FirstOrDefault(caixa => caixa.UsuarioId == idUsuario);
        }

        public void update(Caixa caixa)
        {
           this._context.caixas.Update(caixa); this._context.SaveChanges();
        }
    }
}

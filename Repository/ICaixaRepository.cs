using apiPagamento.Models;

namespace apiPagamento.Repository
{
    public interface ICaixaRepository
    {
        public void add(Caixa caixa);
        public void update(Caixa caixa);
        public void delete(Caixa caixa);
        public Caixa Get(int idUsuario);

    }
}

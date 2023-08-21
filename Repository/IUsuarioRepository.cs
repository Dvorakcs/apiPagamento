using apiPagamento.Models;

namespace apiPagamento.Repository;


public interface IUsuarioRespository{
    void Add(Usuario usuario);
    List<Usuario> Get();
    
}
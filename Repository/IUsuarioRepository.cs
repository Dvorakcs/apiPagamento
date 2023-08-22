using apiPagamento.Models;

namespace apiPagamento.Repository;


public interface IUsuarioRespository{
    void Add(Usuario usuario);
    List<Usuario> Get();
    Usuario Get(int id);
    Usuario Update(Usuario usuario);
    bool Delete(Usuario usuario);
    Usuario GetUserForLogin(string email,string password);

}
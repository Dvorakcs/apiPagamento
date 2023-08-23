using apiPagamento.Models;
using apiPagamento.Repository;

namespace apiPagamento.Services;
public class UsuarioService {

    private readonly IUsuarioRespository usuarioRespository;
    public UsuarioService(IUsuarioRespository usuarioRespository)
    {
        this.usuarioRespository = usuarioRespository;
    }
    public List<Usuario> GetAllUser(){
        return usuarioRespository.Get();
    }

    public Usuario GetUser(Usuario usuario)
    {
        return usuarioRespository.Get(usuario.Id);
    }

    public Usuario GetUser(int id)
    {
        return usuarioRespository.Get(id);
    }

    public void AddUser(Usuario usuario)
    {
        usuarioRespository.Add(usuario);
    }

}
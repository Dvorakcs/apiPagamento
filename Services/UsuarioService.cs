using apiPagamento.Models;
using apiPagamento.Repository;

namespace apiPagamento.Services;
public class UsuarioService {

    private readonly IUsuarioRespository usuarioRespository;
    public UsuarioService(IUsuarioRespository usuarioRespository)
    {
        this.usuarioRespository = usuarioRespository;
    }


    public List<Usuario> GetUser(){
        return usuarioRespository.Get();
    }
}
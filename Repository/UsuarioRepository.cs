using apiPagamento.Context;
using apiPagamento.Models;


namespace apiPagamento.Repository;
public class UsuarioRepository: IUsuarioRespository {

    private readonly PagamentoContext _context = new PagamentoContext();
    public void Add(Usuario usuario){

        if (usuario != null)
        {
            _context.usuarios.Add(usuario);
            _context.SaveChanges();
        }
     
    }

    public bool Delete(Usuario usuario)
    {
       Usuario usuarioDb = this.Get(usuario.Id);
       _context.Remove(usuario);
       _context.SaveChanges();

        return true;
    }

    public  List<Usuario> Get(){
            
        return _context.usuarios.ToList();
    }

    public Usuario Get(int id)
    {
        return _context.usuarios.Find(id);
    }

    public Usuario Update(Usuario usuario)
    {
        Usuario usuarioDb = this.Get(usuario.Id);
        usuario = usuarioDb;
        _context.Update(usuario);

        return usuario;
    }
}
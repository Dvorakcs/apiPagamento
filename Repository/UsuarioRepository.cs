using apiPagamento.Context;
using apiPagamento.Models;


namespace apiPagamento.Repository;
public class UsuarioRepository: IUsuarioRespository {

        private readonly PagamentoContext _context = new PagamentoContext();
        public void Add(Usuario usuario){
              
        }

        public  List<Usuario> Get(){
            
           return _context.usuarios.ToList();
        }

}
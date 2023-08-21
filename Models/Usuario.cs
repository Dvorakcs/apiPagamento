using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiPagamento.Models;
[Table("usuario")]
public class Usuario{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string ConfirmaSenha { get; set; }
    public int tipoUsuarioId {get; set;}
    public TipoUsuario tipoUsuario {get; set;}


   public Usuario(string Nome, string CPF, string Email, string Senha, string ConfirmaSenha, int tipoUsuarioId)
   {
        this.Nome = Nome;
        this.CPF = CPF;
        this.Email = Email;
        this.Senha = Senha;
        this.ConfirmaSenha = ConfirmaSenha;
        this.tipoUsuarioId = tipoUsuarioId;
   }
}
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
    public TipoUsuario Tipo { get; set; }


   public Usuario(string Nome, string CPF, string Email, string Senha, string ConfirmaSenha, TipoUsuario tipo)
   {
        this.Nome = Nome;
        this.CPF = CPF;
        this.Email = Email;
        this.Senha = Senha;
        this.ConfirmaSenha = ConfirmaSenha;
        this.Tipo = tipo;
   }
}
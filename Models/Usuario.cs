namespace apiPagamento.Models;

public class Usuario{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public string? ConfirmaSenha { get; set; }
    public TipoUsuario tipoUsuario {get; set;}
}
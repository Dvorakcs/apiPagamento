using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiPagamento.Models
{
    [Table("caixa")]
    public class Caixa
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public double QuantidadeValorCaixa { get; set; }

        public Caixa(int usuarioId, double QuantidadeValorCaixa)
        {
            this.UsuarioId = usuarioId;
            this.QuantidadeValorCaixa = QuantidadeValorCaixa;
        }
    }
}

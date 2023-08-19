using apiPagamento.Models;
using Microsoft.EntityFrameworkCore;

namespace apiPagamento.Context;

public class PagamentoContext:DbContext{
    public PagamentoContext(DbContextOptions<PagamentoContext> options)
        :base(options){
        
    }


    public DbSet<Usuario> usuarios {get;set;} = null!;
}
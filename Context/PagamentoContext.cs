using apiPagamento.Models;
using Microsoft.EntityFrameworkCore;

namespace apiPagamento.Context;

public class PagamentoContext:DbContext{
     readonly static string connectionStringBd = "server=localhost;user=dev;password=dev_123;database=paydy";
    readonly static ServerVersion serverVersion = new MySqlServerVersion(ServerVersion.AutoDetect(connectionStringBd));
        

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
       optionsBuilder.UseMySql(connectionStringBd,serverVersion);
    }
    public DbSet<Usuario> usuarios {get;set;} = null!;
}
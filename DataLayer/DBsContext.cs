using DataLayer.Entities.Account;
using Microsoft.EntityFrameworkCore;
namespace DataLayer;
public class DBsContext : DbContext
{

    private static string ConnectionString()
    {
        return "Server=.; DataBase=CSharpApp.DB; Integrated Security=True;TrustServerCertificate=true";
    }

    #region Account

    public DbSet<User> Users { get; set; }

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString());
    }

}
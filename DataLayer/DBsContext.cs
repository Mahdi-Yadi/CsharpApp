using DataLayer.Entities.Account;
using DataLayer.Entities.Orders;
using DataLayer.Entities.Products;
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

    #region Product

    public DbSet<Product> Products { get; set; }

    #endregion


    #region Orders 

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString());
    }

}
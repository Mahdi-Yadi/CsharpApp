using DataLayer.Entities.Account;
namespace DataLayer.Entities.Products;
public class Product
{
    
    public int Id { get; set; }

    public string Name { get; set; }

    public string Price { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UserId { get; set; }

    // Relations

    public User User { get; set; }

}
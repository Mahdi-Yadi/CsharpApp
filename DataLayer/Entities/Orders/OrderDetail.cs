using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.Orders;
public class OrderDetail
{
    [Key]
    public int Id { get; set; }

    public int Price { get; set; } 

    public string Name { get; set; }

    public int Count { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public Order Order { get; set; }

}
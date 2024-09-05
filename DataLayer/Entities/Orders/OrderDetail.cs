namespace DataLayer.Entities.Orders;
public class OrderDetail
{
    
    public int Id { get; set; }

    public int Price { get; set; } 

    public string Name { get; set; }

    public int OrderId { get; set; }

    public Order Order { get; set; }

}
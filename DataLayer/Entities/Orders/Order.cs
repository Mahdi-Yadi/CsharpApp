namespace DataLayer.Entities.Orders;
public class Order
{
    
    public int Id { get; set; }

    public string FullName { get; set; }

    public int Sum { get; set; }

    public DateTime CreatedDate { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }

}
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.Account;
public class User 
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string PhonNumber { get; set; }

    public DateTime CreateDate { get; set; }

}
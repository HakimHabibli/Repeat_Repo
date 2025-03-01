namespace ECommerce.Domain.Entities;

public class Order:BaseEntity
{
    //public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public decimal TotalPrice { get; set; }

}

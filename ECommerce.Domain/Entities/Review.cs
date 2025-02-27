namespace ECommerce.Domain.Entities;

public class Review : BaseEntity
{            
    public int ProductId { get; set; }            
    public int UserId { get; set; }                
    public string Comment { get; set; } = null!;   
    public int Rating { get; set; }                
    public DateTime CreatedAt { get; set; }        
}
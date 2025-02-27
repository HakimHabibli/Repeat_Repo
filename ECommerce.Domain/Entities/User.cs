namespace ECommerce.Domain.Entities;

public class User:BaseEntity
{                    
    public string FirstName { get; set; } = null!;   
    public string LastName { get; set; } = null!;  
    public string Email { get; set; } = null!;       
    public string PasswordHash { get; set; } = null!;
    public string? PhoneNumber { get; set; }         
    public DateTime CreatedAt { get; set; }         
    public DateTime UpdatedAt { get; set; }         
}
namespace ECommerce.Domain.Entities;

public class WishList:BaseEntity
{                   
    public int UserId { get; set; }                
    public ICollection<WishListItem> WishListItems { get; set; } = new List<WishListItem>();
}

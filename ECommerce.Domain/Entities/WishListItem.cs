namespace ECommerce.Domain.Entities;

public class WishListItem : BaseEntity
{
    public int WishListId { get; set; }
    public int ProductId { get; set; }
}

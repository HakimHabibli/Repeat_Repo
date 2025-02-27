namespace ECommerce.Domain.Entities;

public class Category:BaseEntity
{
    //public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }

}

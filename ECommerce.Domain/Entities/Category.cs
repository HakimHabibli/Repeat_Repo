namespace ECommerce.Domain.Entities;

public class Category:BaseEntity
{
    #region Prop's
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    #endregion

    #region Relation's

    public ICollection<Product> Products { get; set; }

    #endregion

}

namespace ECommerce.Domain.Entities;

public class Product:BaseEntity
{
    //public int ProductId { get; set; }
    #region Prop's

    public string Name { get; set; }
    public string PhotoPath { get; set; }
    public string Price { get; set; }
    public bool IsAvailable { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }

    #endregion

    #region Relation's
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    #endregion

}
namespace InvokeApp.Core.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public int ConditionId { get; set; }

    public string Description { get; set; } = null!;

    public int Price { get; set; }

    public int SellerId { get; set; }

    public bool Sold { get; set; }

    public DateTime Date { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Condition Condition { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual User Seller { get; set; } = null!;
}

namespace InvokeApp.Core.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

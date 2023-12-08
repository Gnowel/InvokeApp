namespace InvokeApp.Core.Entities;

public partial class Deal
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public virtual User Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

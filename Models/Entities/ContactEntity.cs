namespace Crito.Models.Entities;

public class ContactEntity
{
    public int Id { get; set; }
    public Guid ContactKey { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Description { get; set; }
}

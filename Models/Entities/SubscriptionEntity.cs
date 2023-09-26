namespace Crito.Models.Entities;

public class SubscriptionEntity
{

        public int Id { get; set; }
        public Guid SubscriptionUmbracoKey { get; set; }
        public required string Email { get; set; }
}

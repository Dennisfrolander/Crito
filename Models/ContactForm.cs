using Crito.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class ContactForm
{
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    public string Message { get; set; } = null!;
    public string? ReDirectUrl { get; set; } = "/";


    public static implicit operator ContactEntity(ContactForm form)
    {
        return new ContactEntity
        {
            Description = form.Message,
            Name = form.Name,
            Email = form.Email,
        };
    }
}

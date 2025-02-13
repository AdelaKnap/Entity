using System.ComponentModel.DataAnnotations;
namespace Entity.Models;

public class Author
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Namn")]
    public string? Name { get; set; }

    public List<Book>? Books { get; set; }     // Lista med böcker för varje författare
}
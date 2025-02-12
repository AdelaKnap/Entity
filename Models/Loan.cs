using System.ComponentModel.DataAnnotations;
namespace Entity.Models;

public class Loan
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Låntagarens namn")]
    public string? Borrower { get; set; }

    public List<Book>? BorrowedBooks { get; set; }     // Lista med böcker för varje lån
}
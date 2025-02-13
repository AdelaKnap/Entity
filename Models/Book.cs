namespace Entity.Models;

using System.ComponentModel.DataAnnotations;

public class Book
{
    //Propertis
    public int Id { get; set; }

    [Required]
    [Display(Name = "Titel")]
    public string? Title { get; set; }

    [Display(Name = "Läst")]
    public bool Read { get; set; }

    [Display(Name = "Författare")]
    public int? AuthorId { get; set; }

    [Display(Name = "Författare")]
    public Author? Author { get; set; }

    [Display(Name = "Utlånad till")]
    public int? LoanId { get; set; }

    [Display(Name = "Utlånad till")]
    public Loan? Loan { get; set; }

    [Display(Name = "Utlåningsdatum")]
    public DateTime? LoanDate { get; set; }
}
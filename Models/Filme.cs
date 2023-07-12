using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Models;

[Table("Filmes")]
public class Filme
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Director { get; set; }

    [Required]
    public string Genre { get; set; }

    [Required]
    public int Duration { get; set; }
}
    
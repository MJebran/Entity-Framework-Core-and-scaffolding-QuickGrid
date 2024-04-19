using System.ComponentModel.DataAnnotations;

namespace BlazorMovieAPP.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime? RelaseDate { get; set; }

    public string? Genre { get; set; }

    public decimal? Price { get; set; }

}
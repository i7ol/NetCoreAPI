using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
public class Movie{
    public int Id{get;set;}
    public string? Tiltle {get;set;}
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get;set;}
    public string? Gender{get;set;}
    public decimal Price{get;set;}
}
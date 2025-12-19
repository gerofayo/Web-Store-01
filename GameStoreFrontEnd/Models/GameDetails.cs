using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStoreFrontEnd.Converters;

namespace GameStoreFrontEnd.Models;

public class GameDetails
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter a Name")]
    [StringLength(50, ErrorMessage = "Name has a a maximum length of 50 char")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Select a Genre")]
    [JsonConverter(typeof(StringConverter))]
    public string? GenreId  { get; set; }

    [Range(0,99.9)]
    public decimal Price { get; set; }

    public DateOnly Release { get; set; }
}
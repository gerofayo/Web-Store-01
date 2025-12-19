using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStoreAPI.Converters;

namespace GameStoreAPI.Contracts;


public record CreateGameDTO(

    [Required][StringLength(50)] 
    string Name,
        
    int GenreId,

    [Required][Range(0,99)]
    decimal Price,

    DateTime Release
);

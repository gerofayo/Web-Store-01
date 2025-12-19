using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.Contracts;

public record class UpdateGameDTO(
    [Required][StringLength(50)] 
    string Name,
    
    int GenreId,

    [Required][Range(0,99)]
    decimal Price,

    DateOnly Release
);

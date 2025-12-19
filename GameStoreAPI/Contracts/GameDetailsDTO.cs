using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.Contracts;
public record class GameDetailsDTO(
    int Id,
    string Name, 
    int GenreId, 
    decimal Price, 
    DateOnly Release
);

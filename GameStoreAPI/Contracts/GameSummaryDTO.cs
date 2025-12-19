using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.Contracts;
public record class GameSummaryDTO(
    int Id,
    string Name, 
    string Genre, 
    decimal Price, 
    DateOnly Release
);

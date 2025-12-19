using System.Text.Json;
using GameStoreFrontEnd.Models;
namespace GameStoreFrontEnd.Clients;

public class GamesClient(HttpClient httpClient)
{ 
    private string baseRoute = "games";
    public async Task<GameSummary[]> GetGamesAsync() 
        => await httpClient.GetFromJsonAsync<GameSummary[]>(baseRoute) ?? []
    ;
    public async Task<GameDetails> GetGameAsync(int id) 
        => await httpClient.GetFromJsonAsync<GameDetails>($"{baseRoute}/{id}")
        ?? throw new Exception($"Could not find game!")
    ;
    public async Task AddGameAsync(GameDetails game)
    {
        Console.WriteLine($"AddGameAsync:ReleaseDate: {game.Release}");;
        await httpClient.PostAsJsonAsync<GameDetails>(baseRoute, game);
    }

    public async Task UpdateGameAsync(GameDetails updatedGame)
    {
        await httpClient.PutAsJsonAsync($"{baseRoute}/{updatedGame.Id}", updatedGame);
    }

    public async Task DeleteGameAsync(int id) 
        => await httpClient.DeleteAsync($"{baseRoute}/{id}")
    ;

}

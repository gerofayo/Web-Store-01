using GameStoreAPI.Contracts;
using GameStoreAPI.Entities;

namespace GameStoreAPI.Mapping
{
    public static class GameMapping
    {
        public static Game ToEntity(this CreateGameDTO game)
        {
            return new Game()
            {
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                Release = DateOnly.FromDateTime(game.Release)
            };
        }

        public static Game ToEntity(this UpdateGameDTO game, int id)
        {
            return new Game()
            {
                Id = id,
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                Release = game.Release
            };
        }

        public static GameSummaryDTO ToGameSummaryDTO(this Game game)
        {
            return new GameSummaryDTO(
                game.Id,
                game.Name,
                game.Genre!.Name,
                game.Price,
                game.Release
            );
        }

        public static GameDetailsDTO ToGameDetailsDTO(this Game game)
        {
            return new GameDetailsDTO(
                game.Id,
                game.Name,
                game.GenreId,
                game.Price,
                game.Release
            );
        }
    }
}


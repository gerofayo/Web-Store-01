
using GameStoreAPI.Contracts;
using GameStoreAPI.Entities;

namespace GameStoreAPI.Mapping;


public static class GenreMapping
{
    public static GenreDTO ToDTO(this Genre genre)
    {
        return new GenreDTO(genre.Id, genre.Name);
    }  

}

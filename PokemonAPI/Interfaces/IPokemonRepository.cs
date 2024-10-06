using PokemonAPI.Dto;
using PokemonAPI.Entities;

namespace PokemonAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(Guid id);
        Pokemon GetPokemon(string name);
        Pokemon GetPokemonTrimToUpper(PokemonDto pokemonCreate);
        decimal GetPokemonRating(Guid pokeId);
        bool PokemonExists(Guid pokeId);
        bool CreatePokemon(Guid ownerId, Guid categoryId, Pokemon pokemon);
        bool UpdatePokemon(Guid ownerId, Guid categoryId, Pokemon pokemon);
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}

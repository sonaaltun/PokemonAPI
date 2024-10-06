using PokemonAPI.Entities;

namespace PokemonAPI.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(Guid ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(Guid pokeId);
        ICollection<Pokemon> GetPokemonByOwner(Guid ownerId);
        bool OwnerExists(Guid ownerId);
        bool CreateOwner(Owner owner);
        bool UpdateOwner(Owner owner);
        bool DeleteOwner(Owner owner);
        bool Save();
    }
}

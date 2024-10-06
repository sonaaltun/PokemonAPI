
using PokemonAPI.Entities;

namespace PokemonAPI.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(Guid id);
        Country GetCountryByOwner(Guid ownerId);
        ICollection<Owner> GetOwnersFromACountry(Guid countryId);
        bool CountryExists(Guid id);
        bool CreateCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
        bool Save();
    }
}

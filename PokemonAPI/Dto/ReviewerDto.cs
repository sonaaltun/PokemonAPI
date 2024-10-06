using PokemonAPI.Entities;

namespace PokemonAPI.Dto
{
    public class ReviewerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

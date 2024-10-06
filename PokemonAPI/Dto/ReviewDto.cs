using PokemonAPI.Entities;

namespace PokemonAPI.Dto
{
    public class ReviewDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}

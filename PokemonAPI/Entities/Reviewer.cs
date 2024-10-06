﻿namespace PokemonAPI.Entities
{
    public class Reviewer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}

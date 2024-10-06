using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.Entities;

namespace PokemonAPI.Configurations
{
    public class PokemonCategoryConfiguration : IEntityTypeConfiguration<PokemonCategory>
    {
        public void Configure(EntityTypeBuilder<PokemonCategory> builder)
        {

            // Composite key for the many-to-many relationship table
            builder.HasKey(pc => new { pc.PokemonId, pc.CategoryId });

            // Relationship between Pokemon and PokemonCategory
            builder.HasOne(pc => pc.Pokemon)
                   .WithMany(p => p.PokemonCategories)
                   .HasForeignKey(pc => pc.PokemonId);

            // Relationship between Category and PokemonCategory
            builder.HasOne(pc => pc.Category)
                   .WithMany(c => c.PokemonCategories)
                   .HasForeignKey(pc => pc.CategoryId);
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Entities;

namespace PokemonAPI.Configurations
{
    public class PokemonOwnerConfiguration : IEntityTypeConfiguration<PokemonOwner>
    {
        public void Configure(EntityTypeBuilder<PokemonOwner> builder)
        {
            // Composite key for the many-to-many relationship table
            builder.HasKey(po => new { po.PokemonId, po.OwnerId });

            // Relationship between Pokemon and PokemonOwner
            builder.HasOne(po => po.Pokemon)
                   .WithMany(p => p.PokemonOwners)
                   .HasForeignKey(po => po.PokemonId);

            // Relationship between Owner and PokemonOwner
            builder.HasOne(po => po.Owner)
                   .WithMany(o => o.PokemonOwners)
                   .HasForeignKey(po => po.OwnerId);
        }
    }
}

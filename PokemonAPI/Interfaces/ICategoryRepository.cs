using PokemonAPI.Entities;

namespace PokemonAPI.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(Guid id);
        ICollection<Pokemon> GetPokemonByCategory(Guid categoryId);
        bool CategoryExists(Guid id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}

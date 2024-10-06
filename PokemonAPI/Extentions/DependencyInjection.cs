using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Interfaces;
using PokemonAPI.Repositories;
using PokemonAPI.Repository;
using System.Text.Json.Serialization;

namespace PokemonAPI.Extentions;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Default"));
        });
        services.AddTransient<Seed>();
        services.AddControllers().AddJsonOptions(x =>x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IPokemonRepository, PokemonRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IOwnerRepository, OwnerRepository>();
        services.AddScoped<IReviewRepository, ReviewRepository>();
        services.AddScoped<IReviewerRepository, ReviewerRepository>();


        return services;
    }
}
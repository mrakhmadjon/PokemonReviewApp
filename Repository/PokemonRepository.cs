using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDbContext pokemonDbContext;

        public PokemonRepository(PokemonDbContext pokemonDbContext)
        {
            this.pokemonDbContext = pokemonDbContext;
        }
        public ICollection<Pokemon> GetPokemons()
        {
            return pokemonDbContext.Pokemons.OrderBy(i =>  i.Id).ToList();  
        }
    }
}

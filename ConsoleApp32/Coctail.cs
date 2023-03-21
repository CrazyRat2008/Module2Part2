
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class Cocktail
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; } 
    }
    public interface ICocktailRepository
    {
        List<Cocktail> GetAllCocktails();
        Cocktail GetCocktailByName(string name); 
    }
    public class MockCocktailRepository : ICocktailRepository
    {
        private List<Cocktail> cocktails;

        public MockCocktailRepository()
        {
            cocktails = new List<Cocktail>
        {
            new Cocktail { Name = "Margarita", Ingredients = new List<string> { "Tequila", "Lime Juice", "Triple Sec" }, Instructions = "Shake with ice and strain into glass" },
            new Cocktail { Name = "Cosmopolitan", Ingredients = new List<string> { "Vodka", "Cointreau", "Cranberry Juice", "Lime Juice" }, Instructions = "Shake with ice and strain into glass" },
          
        };
        }

        public List<Cocktail> GetAllCocktails()
        {
            return cocktails;
        }

        public Cocktail GetCocktailByName(string name)
        {
            return cocktails.FirstOrDefault(c => c.Name == name);
        }
    }
    public class CocktailService
    {
        private readonly ICocktailRepository cocktailRepository;

        public CocktailService(ICocktailRepository cocktailRepository)
        {
            this.cocktailRepository = cocktailRepository;
        }

        public List<Cocktail> GetAllCocktails()
        {
            return cocktailRepository.GetAllCocktails();
        }

        public Cocktail GetCocktailByName(string name)
        {
            return cocktailRepository.GetCocktailByName(name);
        }
    }
}

using System.Collections.Generic;

namespace PizzaBuilderDemo
{
    public class Pizza
    {
        private readonly List<string> _ingredients = new List<string>();

        public void Add(string ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public string ListIngredients()
        {
            if (_ingredients.Count == 0)
                return "Pizza has no ingredients.\n";

            string result = string.Join(", ", _ingredients);
            return "Pizza with: " + result + "\n";
        }
    }
}


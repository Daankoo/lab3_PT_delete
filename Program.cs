using System;

namespace PizzaBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new PizzaDirector();
            var cheeseBuilder = new CheesePizzaBuilder();
            var pepperoniBuilder = new PepperoniPizzaBuilder();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("==== PIZZA MENU ====");
                Console.WriteLine("1 - Basic Cheese Pizza");
                Console.WriteLine("2 - Full Cheese Pizza");
                Console.WriteLine("3 - Basic Pepperoni Pizza");
                Console.WriteLine("4 - Full Pepperoni Pizza");
                Console.WriteLine("5 - Custom Pepperoni (dough + toppings)");
                Console.WriteLine("0 - Exit");
                Console.Write("Choose option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        director.Builder = cheeseBuilder;
                        director.BuildBasicPizza();
                        Console.WriteLine("You ordered: Basic Cheese Pizza");
                        Console.WriteLine(cheeseBuilder.GetPizza().ListIngredients());
                        break;

                    case "2":
                        director.Builder = cheeseBuilder;
                        director.BuildFullFeaturedPizza();
                        Console.WriteLine("You ordered: Full Cheese Pizza");
                        Console.WriteLine(cheeseBuilder.GetPizza().ListIngredients());
                        break;

                    case "3":
                        director.Builder = pepperoniBuilder;
                        director.BuildBasicPizza();
                        Console.WriteLine("You ordered: Basic Pepperoni Pizza");
                        Console.WriteLine(pepperoniBuilder.GetPizza().ListIngredients());
                        break;

                    case "4":
                        director.Builder = pepperoniBuilder;
                        director.BuildFullFeaturedPizza();
                        Console.WriteLine("You ordered: Full Pepperoni Pizza");
                        Console.WriteLine(pepperoniBuilder.GetPizza().ListIngredients());
                        break;

                    case "5":
                        director.Builder = pepperoniBuilder;
                        pepperoniBuilder.AddDough();
                        pepperoniBuilder.AddToppings();
                        Console.WriteLine("You ordered: Custom Pepperoni (no sauce)");
                        Console.WriteLine(pepperoniBuilder.GetPizza().ListIngredients());
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Unknown option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

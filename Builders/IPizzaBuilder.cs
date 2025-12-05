using Builder.Product;

namespace Builder.Builders
{
    public interface IPizzaBuilder
    {
        void AddDough();
        void AddSauce();
        void AddToppings();
        Pizza GetPizza();
    }
}


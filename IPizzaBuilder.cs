namespace PizzaBuilderDemo
{
    public interface IPizzaBuilder {
        void AddDough();
        void AddSauce();
        void AddToppings();
        Pizza GetPizza();
    }
}


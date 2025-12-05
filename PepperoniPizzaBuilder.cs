namespace PizzaBuilderDemo
{
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PepperoniPizzaBuilder() {
            Reset();
        }

        public void Reset() {
            _pizza = new Pizza();
        }

        public void AddDough() {
            _pizza.Add("Dough");
        }

        public void AddSauce() {
            _pizza.Add("Tomato sauce");
        }

        public void AddToppings() {
            _pizza.Add("Cheese");
            _pizza.Add("Pepperoni");
        }

        public Pizza GetPizza() {
            Pizza result = _pizza;
            Reset();
            return result;
        }
    }
}

namespace PizzaBuilderDemo
{
    public class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public IPizzaBuilder Builder {
            set { _builder = value; }
        }

        public void BuildBasicPizza() {
            _builder.AddDough();
            _builder.AddSauce();
        }

        public void BuildFullFeaturedPizza() {
            _builder.AddDough();
            _builder.AddSauce();
            _builder.AddToppings();
        }
    }
}


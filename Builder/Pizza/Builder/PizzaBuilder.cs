public class PizzaBuilder
{
    private Pizza pizza = new Pizza();

    public PizzaBuilder AddTomato()
    {
        pizza.Tomato = true;
        return this;
    }

    public PizzaBuilder AddCheese()
    {
        pizza.Cheese = true;
        return this;
    }

    public PizzaBuilder AddPepperoni()
    {
        pizza.Pepperoni = true;
        return this;
    }

    public Pizza Prepare()
    {
        if (pizza.Tomato && !pizza.Cheese)
        {
            throw new Exception("Cannot have pizza with sauce but without cheese");
        }
        return pizza;
    }
}
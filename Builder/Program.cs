public class Pizza
{
    public bool Tomato = false;

    public bool Cheese = false;

    public bool Pepperoni = false;
}

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

public class Program
{
    public static void Main(string[] args)
    {
        PizzaBuilder pizzaBuilder = new PizzaBuilder();

        Pizza pizza = pizzaBuilder.AddCheese().AddTomato().Prepare();

        Console.WriteLine("Cheese: " + pizza.Cheese);
        Console.WriteLine("Tomato: " + pizza.Tomato);
        Console.WriteLine("Pepperoni: " + pizza.Pepperoni);
    }
}
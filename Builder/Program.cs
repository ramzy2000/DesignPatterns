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

using System.Runtime.CompilerServices;

public interface IAnimal
{
    public string MakeSound();
}

public class Dog : IAnimal
{
    public string MakeSound()
    {
        return "Bark";
    }
}

public class Cat : IAnimal
{
    public string MakeSound()
    {
        return "Meow";
    }
}

public interface IAnimalFactory
{
    public IAnimal CreateAnimal(bool mustKeepWatch);
}

public class AnimalFactory : IAnimalFactory
{
    public IAnimal CreateAnimal(bool mustKeepWatch)
    {
        if (mustKeepWatch)
        {
            return new Dog();
        }
        return new Cat();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AnimalFactory animalFactory = new AnimalFactory();

        IAnimal animal = animalFactory.CreateAnimal(true);
        Console.WriteLine(animal.MakeSound());
    }
}
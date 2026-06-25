using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {
        AnimalFactory animalFactory = new AnimalFactory();

        List<IAnimal> animals = new List<IAnimal>();

        animals.Add(animalFactory.CreateAnimal(true));
        animals.Add(animalFactory.CreateAnimal(false));
        
        foreach(IAnimal animal in animals)
        {
            Console.WriteLine("Make Noise: "+animal.MakeSound());
        }
    }
}

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
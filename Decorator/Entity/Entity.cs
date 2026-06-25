namespace Entity;

public class Entity : IEntity
{
    public void Update(float dt)
    {
        Console.WriteLine("Entity is updating");
    }
}
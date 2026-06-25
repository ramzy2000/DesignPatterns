namespace Entity;

public class Program
{
    public static void Main(string[] args)
    {
        IEntity entity = new Entity();

        entity = new EntitySpriteDecorator(entity);

        entity = new EntityMovementDecorator(entity);

        entity.Update(10);
    }
}
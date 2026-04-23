public interface IEntity
{
    void Update(float dt);
}

public class Entity : IEntity
{
    public void Update(float dt)
    {
        Console.WriteLine("Entity is updating");
    }
}

public class EntityDecorator : IEntity
{
    IEntity entity;

    public EntityDecorator(IEntity entity)
    {
        this.entity = entity;
    }

    public virtual void Update(float dt)
    {
        entity.Update(dt);
    }
}

public class EntitySpriteDecorator : EntityDecorator
{
    public EntitySpriteDecorator(IEntity entity) : base(entity)
    {
        
    }

    public override void Update(float dt)
    {
        Console.WriteLine("Entity sprite is updating");
        base.Update(dt);
    }
}

public class EntityMovementDecorator : EntityDecorator
{
    public EntityMovementDecorator(IEntity entity) : base(entity)
    {
        
    }

    public override void Update(float dt)
    {
        Console.WriteLine("Entity movement is updating");
        base.Update(dt);
    }
}

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
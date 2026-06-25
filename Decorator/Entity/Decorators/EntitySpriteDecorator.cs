namespace Entity;

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
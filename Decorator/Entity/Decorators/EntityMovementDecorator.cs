namespace Entity;

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
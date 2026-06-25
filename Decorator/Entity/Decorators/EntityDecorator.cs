namespace Entity;

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
public abstract class VehicleDecorator : IVehicle
{

    protected IVehicle Vehicle;
    public VehicleDecorator(IVehicle vehicle)
    {
        Vehicle = vehicle;
    }

    public  virtual string GetDescription()
    {
        return "";
    }

    public virtual float GetCost()
    {
        return 10000;
    }
}
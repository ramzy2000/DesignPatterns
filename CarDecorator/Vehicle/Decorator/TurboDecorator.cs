using System.Security.Cryptography.X509Certificates;

public class TurboDecorator : VehicleDecorator
{
    public TurboDecorator(IVehicle vehicle) : base(vehicle)
    {
        
    }

    public override string GetDescription()
    {
        return Vehicle.GetDescription() + "Turbo | ";
    }

    public override float GetCost()
    {
        return Vehicle.GetCost()+10000;
    }
}
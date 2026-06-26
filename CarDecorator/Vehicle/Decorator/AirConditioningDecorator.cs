using System.Security.Cryptography.X509Certificates;

public class AirConditioningDecorator : VehicleDecorator
{
    public AirConditioningDecorator(IVehicle vehicle) : base(vehicle)
    {
        
    }

    public override string GetDescription()
    {
        return Vehicle.GetDescription() + "Air Conditioning | ";
    }

    public override float GetCost()
    {
        return Vehicle.GetCost()+10000;
    }
}
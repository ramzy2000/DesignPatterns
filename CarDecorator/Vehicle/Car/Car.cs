public class Car : IVehicle
{
    public string GetDescription()
    {
        return "Car | ";
    }

    public float GetCost()
    {
        return 40000;
    }
}
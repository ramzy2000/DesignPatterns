public class CarCustomizer
{
    IVehicle Vehicle;

    public CarCustomizer()
    {
        Vehicle = new Car();
    }

    public IVehicle AddAccessory(VehicleDecorator vehicleDecorator)
    {
        Vehicle = vehicleDecorator;
        return Vehicle;
    }

    public IVehicle PreviewCustomizedCar()
    {
        return Vehicle;
    }
}
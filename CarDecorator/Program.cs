public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car(); // car record
        CarCustomizer carCustomizer = new CarCustomizer(); // this lets you customize a car

        IVehicle previewCar = carCustomizer.AddAccessory(new AirConditioningDecorator(car));
        previewCar = carCustomizer.AddAccessory(new TurboDecorator(previewCar));

        Console.WriteLine("Current car:");
        PrintVehicle(car);
        Console.WriteLine("Preview car:");
        PrintVehicle(previewCar);
    }

    public static void PrintVehicle(IVehicle vehicle)
    {
        Console.WriteLine("Car Description: "+ vehicle.GetDescription());
        Console.WriteLine("Car Cost: "+ vehicle.GetCost());
    }
}
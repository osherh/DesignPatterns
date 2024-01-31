namespace DesignPattern.Creational.Builder.Faceted;
public class Program
{
    static void Main(string[] args)
    {
        CarBuilderFacade builder = new CarBuilderFacade();
        Car car = builder
            .Type
                .WithMake("Toyota")
                .OfModel("Corolla")
            .Specs
                .Colored("Blue")
                .FromYear(2021)
            .Features
                .WithNavigationSystem()
                .WithBluetoothSystem();

        Console.WriteLine(car);
    }
}
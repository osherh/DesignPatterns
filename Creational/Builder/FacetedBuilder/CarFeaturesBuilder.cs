namespace DesignPattern.Creational.Builder.Faceted;
internal class CarFeaturesBuilder : CarBuilderFacade
{
    internal CarFeaturesBuilder(Car car)
    {
        this.car = car;
    }

    internal CarFeaturesBuilder WithNavigationSystem()
    {
        car.Features.NavigationSystem = true;
        return this;
    }

    internal CarFeaturesBuilder WithBluetoothSystem()
    {
        car.Features.BluetoothSystem = true;
        return this;
    }
}
namespace DesignPattern.Creational.Builder.Faceted;
internal class CarSpecBuilder : CarBuilderFacade
{
    internal CarSpecBuilder(Car car)
    {
        this.car = car;
    }

    internal CarSpecBuilder Colored(string color)
    {
        car.Spec.Color = color;
        return this;
    }

    internal CarSpecBuilder FromYear(int year)
    {
        car.Spec.Year = year;
        return this;
    }
}
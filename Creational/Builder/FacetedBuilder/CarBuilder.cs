namespace DesignPattern.Creational.Builder.Faceted;
internal class CarBuilderFacade
{
    protected Car car = new Car();
    internal CarTypeBuilder Type => new CarTypeBuilder(car);
    internal CarSpecBuilder Specs => new CarSpecBuilder(car);
    internal CarFeaturesBuilder Features => new CarFeaturesBuilder(car);

    public static implicit operator Car(CarBuilderFacade builder)
    {
        return builder.car;
    }
}
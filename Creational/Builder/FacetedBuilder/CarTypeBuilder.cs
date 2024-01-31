namespace DesignPattern.Creational.Builder.Faceted;
internal class CarTypeBuilder : CarBuilderFacade
{
    internal CarTypeBuilder(Car car) 
    {
        this.car = car;
    }
    internal CarTypeBuilder WithMake(string make)
    {
        car.Type.Make = make;
        return this;
    }
    
    internal CarTypeBuilder OfModel(string model)
    {
        car.Type.Model = model;
        return this;
    }
}
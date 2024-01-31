namespace DesignPattern.Creational.Builder.Faceted;
internal class CarType
{
    internal string Make { private get; set; }
    internal string Model { private get; set; }

    public override string ToString()
    {
        return $" {nameof(Make)}: {Make}\n {nameof(Model)}: {Model}";
    }
}
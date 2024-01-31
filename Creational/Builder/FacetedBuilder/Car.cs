namespace DesignPattern.Creational.Builder.Faceted;
internal class Car
{
    internal CarType Type;
    internal CarSpec Spec;
    internal CarFeatures Features;

    internal Car()
    {
        Type = new CarType();
        Spec = new CarSpec();
        Features = new CarFeatures();
    }
    public override string ToString()
    {
        return $"{nameof(Type)}:\n{Type}\n{nameof(Spec)}:{Spec}\n{nameof(Features)}:\n{Features}";
    }
}
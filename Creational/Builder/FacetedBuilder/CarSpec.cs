namespace DesignPattern.Creational.Builder.Faceted;
internal class CarSpec
{
    internal string Color { private get; set; }
    internal int Year { private get; set; }

    public override string ToString()
    {
        return $"\n {nameof(Color)}: {Color}\n {nameof(Year)}: {Year}";
    }
}
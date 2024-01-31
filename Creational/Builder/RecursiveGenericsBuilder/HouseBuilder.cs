namespace DesignPatterns.Builder.RecursiveGenerics;
internal abstract class HouseBuilder
{
    protected House house = new House();
    internal House Build()
    {
        return house;
    }
}
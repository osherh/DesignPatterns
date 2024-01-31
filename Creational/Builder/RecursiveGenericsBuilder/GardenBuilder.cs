namespace DesignPatterns.Builder.RecursiveGenerics;
internal class GardenBuilder<T> : HouseBuilder
  where T : GardenBuilder<T>
{
    internal T WithTreesNumberOf(int count)
    {
        house.Garden.Trees = count;
        return (T)this;
    }

    internal T WithFlowersNumberOf(int count)
    {
        house.Garden.Flowers = count;
        return (T)this;
    }

    internal T WithBushesNumberOf(int count)
    {
        house.Garden.Bushes = count;
        return (T)this;
    }
    internal House Build()
    {
        return house;
    }
}
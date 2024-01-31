namespace DesignPatterns.Builder.RecursiveGenerics;
internal class PoolBuilder<T> : GardenBuilder<PoolBuilder<T>>
  where T : PoolBuilder<T>
{
    internal T WithPoolTemperatueOf(string temperature)
    {
        house.Pool.Temperatue = temperature;
        return (T)this;
    }
    internal T WithPoolSizeOf(string size)
    {
        house.Pool.Size = size;
        return (T)this;
    }
}
namespace DesignPatterns.Builder.RecursiveGenerics;
public class Program
{
    public static void Main(string[] args)
    {
        //I can change the order and it will still work
        var house = House.New
          .WithPoolSizeOf("2 meters long")
          .WithPoolTemperatueOf("25 degrees")
          .WithBushesNumberOf(3)
          .WithFlowersNumberOf(20)
          .WithTreesNumberOf(4)
          .Build();
        Console.WriteLine(house);
    }
}
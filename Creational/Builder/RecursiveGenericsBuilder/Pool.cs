namespace DesignPatterns.Builder.RecursiveGenerics;
internal class Pool
{
	internal string Temperatue { private get; set; }
	internal string Size { private get; set; }

	public override string ToString()
	{
		return $" {nameof(Temperatue)}: {Temperatue}\n {nameof(Size)}: {Size}\n";
	}
}
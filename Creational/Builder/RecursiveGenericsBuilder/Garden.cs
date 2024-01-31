namespace DesignPatterns.Builder.RecursiveGenerics;
internal class Garden
{
	internal int Trees {  private get; set; }
	internal int Flowers { private get; set; }
	internal int Bushes { private get; set; }

public override string ToString()
	{
		return $" {nameof(Trees)}: {Trees}\n {nameof(Flowers)}: {Flowers}\n {nameof(Bushes)}: {Bushes}";
	}
}
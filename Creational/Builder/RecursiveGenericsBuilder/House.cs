namespace DesignPatterns.Builder.RecursiveGenerics;
internal class House
{
	internal Garden Garden { get; set; }
	internal Pool Pool { get; set; }

	internal House()
    {
		Garden = new Garden();
		Pool = new Pool();
    }

	internal class Builder : PoolBuilder<Builder>
	{
		internal Builder() { }
	}
	internal static Builder New => new Builder();

	public override string ToString()
	{
		return $"{nameof(Garden)}:\n{Garden}\n{nameof(Pool)}:\n{Pool}\n";
	}
}
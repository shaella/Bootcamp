class Tree

{
	//variable
	public string? name;
	public int harvestaftersowing;
	public string? harvestingmonth;
	public string? floweringmonth;
	public int maturingfruits;

	public void Watered()
	{
		Console.WriteLine("Tree Watered");
	}

	public void Grow()
	{
		Console.WriteLine("Tree Grow");
	}
}

static class RunTree
{
	static void Main()
	{
		Tree mango = new Tree();
		mango.Watered();
		mango.Grow();
		Console.WriteLine(mango.harvestaftersowing);
		mango.harvestaftersowing = 6;
		mango.name = "Mango";
		Console.WriteLine(mango.maturingfruits);
		mango.maturingfruits = 150;
		mango.floweringmonth = "October-November";
		mango.harvestingmonth = "April-May";

		Console.WriteLine(mango.name);
		Console.WriteLine($"Mango is ready to harvest {mango.harvestaftersowing} years after sowing the seed.");
	}
}
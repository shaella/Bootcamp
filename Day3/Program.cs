class Tree

{
	//variable
	public string? name;
	public int harvestaftersowing;
	public string? harvestingmonth;
	public string? floweringmonth;
	public int maturingfruits;
	private string? fertilizer;
	
	//constructor
	public Tree(string a, string b, string c, int d, int e) 
	{
		name = a;
		harvestingmonth = b;
		floweringmonth = c;
		harvestaftersowing = d;
		maturingfruits = e;
	}
	public void Watered()
	{
		Console.WriteLine($"{name} Watered");
	}

	public void Grow()
	{
		Console.WriteLine($"{name} Grow");
	}
}

static class Plant : Tree
{
	static void Main()
	{
		Plant mango = new Plant();
		mango.Watered();
		mango.Grow();
		mango.name = "Mango";
		mango.harvestingmonth = "April-May";
		mango.floweringmonth = "October-November";
		mango.maturingfruits = 150;
		mango.harvestaftersowing = 6;

		Console.WriteLine(mango.name);
		Console.WriteLine($"Mango is ready to harvest {mango.harvestaftersowing} years after sowing the seed.");
	}
}
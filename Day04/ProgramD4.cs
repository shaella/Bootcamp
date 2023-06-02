class Tree
{
	public string? name;
	public bool? fruits;
	public string? monthtoproducefruit;
	public bool? flowers;
	public string? monthtoflower;
	private string? fertilizer;
	private int? dosesoffertilizer;	
	public virtual void Grow() 
	{
		Console.WriteLine("Tree Grow");
	}	
	public virtual void Watered() 
	{
		Console.WriteLine("Tree Watered");
	}
	public void HaveFruits()
	{
		Console.WriteLine("Apakah pohon ini memiliki buah?");
		Console.WriteLine(Console.ReadLine());		
	}
	public void HaveFlowers()
	{
		Console.WriteLine("Apakah pohon ini memiliki bunga?");
		Console.WriteLine(Console.ReadLine());
	}
	public void Neededtobefertilized()
	{
		Console.WriteLine("Tree need to be fertilized");
	}
}

class Mango : Tree
{
	public override void Grow() 
	{
		Console.WriteLine("Pohon Mangga bertumbuh tegak ke atas");
	}
	public override void Watered()
	{
		Console.WriteLine("Pohon Mangga perlu disiram dua kali sehari");
	}
}

class BitterMelon : Tree 
{
	public override void Grow() 
	{
		Console.WriteLine("Tanaman pare bertumbuh menjalar");
	}
	public override void Watered()
	{
		Console.WriteLine("Tanaman pare perlu disiram dua kali sehari atau seminggu, tergantung cuaca");
	}
}
static class Runxxx 
{
	static void Main() 
	{
		Tree Mango = new Mango();
		Tree BitterMelon = new BitterMelon();
		Mango LittleMango = new Mango();
		Mango.Grow();
		BitterMelon.Grow();
		Mango.Watered();
		BitterMelon.Watered();
		LittleMango.Grow();
	}
}


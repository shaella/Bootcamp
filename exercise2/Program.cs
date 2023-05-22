class Tree 
{
	public string? name;
	public string? fruit;
	public int? maxheight;
	public int? durationofmaturing;
	
	public void Grow()
	{
		Console.WriteLine("Tree will grow");
	}
	public Tree(string a, int b, int c) 
	{
		fruit = a;
		maxheight = b;
		durationofmaturing = c;
	}
}
 
class Programtorun
{
	static void Main() 
	{
		Tree mango = new Tree("has fruit", 3, 10);
		mango.name = "Mango";
		mango.Grow();
		Console.WriteLine($"{mango.name} {mango.fruit} and the tree will grow {mango.maxheight} meters in {mango.durationofmaturing} years");
		Tree apple = new Tree("has fruit", 3, 10);
		apple.name = "Apple";
		Console.WriteLine($"Another Tree is {apple.name}");
		const string monthtoproducefruit = "January";
		const int waitingtime = 7;
		(string x, int y) = ProducingFruit(monthtoproducefruit, waitingtime);
		Console.WriteLine($"The tree {apple.name} will produce fruits on {x} in {y} years ");
	}
	
	static (string, int) ProducingFruit(string monthtoproducefruit, int waitingtime) 
	{
		return (monthtoproducefruit, waitingtime);
	}
}


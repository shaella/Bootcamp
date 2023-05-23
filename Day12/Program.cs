class Dice 
{
	public int sides;
	public string? size;
	
	public Dice(int x, string y) 
	{
		sides = x;
		size = y;
	}
}

class ProgramDice
{
	static void Main() 
	{	
		Dice wood = new Dice(6,"big");
		int[] normal = {1,2,3,4,5,6};
		Console.WriteLine($"The numbers written on normal dice are {normal[0]}, {normal[1]}, {normal[2]}, {normal[3]}, {normal[4]}, and {normal[5]}");
		Dice plastic = new Dice(6,"small");
		int[] special = {0,2,4,6,8,10};
		Console.WriteLine($"The numbers written on plastic dice are {special[0]}, {special[1]}, {special[2]}, {special[3]}, {special[4]}, and {special[5]}");
	}
}

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

class Home 
{
	public int members;
	public string who;
	public string type;
	public string gender;
	public int age;
	public string occupation;
	
	public void Eating()
	{
		Console.WriteLine("All members do need to eat");
	}
	public void Sleeping() 
	{
		Console.WriteLine("All members do need to sleep");
	}
	public void Activities()
	{
		Console.WriteLine("All members have their own activities");
	} 
	public void GrowingUp(int newage)
	{
		age = newage;
	}
	public Home(string a, string b, string c, int d, string e) 
	{
		who = a;
		type = c;
		gender = b;
		age = d;
		occupation = e;
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
		int specialdice = 12;
		dynamic sd = specialdice;
		Console.WriteLine($"There are dices who have {sd} sides");
		int availabledices = 100;
		object obj = availabledices;
		int newobj = (int)obj;
		Console.WriteLine($"We have {newobj} dices to sell");
		}
}

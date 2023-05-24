// delegate

public delegate void Seminar(string name, string when, int duration, int fee);

class Program 
{
	static void Main() 
	{
		Seminar exampdelegate1 = new Seminar(ReceivSeminar);
		exampdelegate1("Hari Bumi", "Wednesday, 8 AM", 2, 100000);
		Console.ReadKey(); 
	}
	
	public static void ReceivSeminar(string rName, string rWhen, int rDuration, int rFee) 
	{
		Console.WriteLine("Minggu ini akan diselenggarakan dua seminar:");
		Console.WriteLine($"Seminar 1\n Judul: {rName}\n  Hari, pukul: {rWhen}\n   Durasi: {rDuration}\n    Biaya: {rFee}");
	}
}
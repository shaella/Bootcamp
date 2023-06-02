// delegate

public delegate void Seminar(string name, Days when, int duration, int fee);
//public delegate void AutomaticShutdown(string message);

public class Program
{
	static void Main()
	{
		Seminar exampdelegate1 = new Seminar(ReceivSeminar);
		exampdelegate1("Hari Bumi", Days.Wednesday, 2, 100000);
		Console.ReadKey();

		static void ReceivSeminar(string rName, Days rWhen, int rDuration, int rFee)
		{
			Console.WriteLine("Minggu ini akan diselenggarakan dua seminar:");
			Console.WriteLine($"Seminar 1\n Judul: {rName}\n  Hari, pukul: {rWhen}\n   Durasi: {rDuration}\n    Biaya: {rFee}");
		}
		
//		Program obj = new Program();
//		AutomaticShutdown exampdelegate2 = new AutomaticShutdown(obj.receivAutomaticSD);
//		DoSomework(exampdelegate2);
		
//		Console.ReadKey();
		
//		static void DoSomework(AutomaticShutdown del)
//		{
//			Console.WriteLine("Loading...");
//			del("The computer will be automatically turned off at 9:00 PM");
//		}
		
//		void receivAutomaticSD(string themessage)
//		{
//			Console.WriteLine($"WARNING: {themessage}. Please finish and/or save your works.");
//		}
	}
}
public enum Days
{
	Sunday,
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday
}	


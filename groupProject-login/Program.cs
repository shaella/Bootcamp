using LoginDB;

class Program 
{
	static void Main() 
	{
		Login logindb = new Login();
		Console.WriteLine($"Name: {logindb.Database}");
		Console.WriteLine($"Database: {logindb.Database.ProviderName}");		
	}
}
namespace Day28;

public class Northwind : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		string path = Path.Combine( Environment.CurrentDirectory, "Northwind.db");
		
		string connection = ($"FIlename={path}");
		
		Console.WriteLine($"Connection: {connection}");
		coptionsBuilder.useSqlite(connection); 
	}
}

using System.Diagnostics;
using System.IO;
class Program 
{
	static void Main() 
	{
		int x = 10;
		int y = 20;
		
		Trace.Listeners.Add(new ConsoleTraceListener());
		Trace.WriteLine($"x = {0}, y = {1}", x, y);
		TextWriterTraceListener listener = new TextWriterTraceListener("trace.log");
		
		Debug.Fail("This is a forced failure.");
		Debug.Assert(x < y, "x should be less than y.");
		Debug.Assert(x > y, "x should be greater than y.");
	}
}
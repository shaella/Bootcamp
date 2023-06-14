using System;
using System.Threading.Tasks;

namespace NineteenTask
{
	class Program
	{
		static async Task Main()
		{
			Task task = new Task(TugasDua);
			//Thread mt = new Thread(Tugas);
			task.Start();
			//task.Wait(); //blocking the current thread
			await task;
			await Tugas();
		}
		public static async Task Tugas()
		{
			string aha = "hello";
			string bha = "everybody";
			for (int i = 0; i < 20; i++)
			{
				await Task.Delay(TimeSpan.FromSeconds(10)); //Dont use Thread.Sleep(1000);
				Console.WriteLine(aha + " " + bha);
				Console.WriteLine("Printing just ended ...");
			}
		}

		public static void TugasDua()
		{
			int x = 10;
			int y = 20;
			int z = x + y;
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(z + (x * y));
			}
		}
	}
}



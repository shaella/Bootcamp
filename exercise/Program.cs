//kode Console.WriteLine(Console.ReadLine()+Console.ReadLine());

//kode int a = int.Parse(Console.ReadLine());
//kode int b = int.Parse(Console.ReadLine());
//kode Console.WriteLine(a+b);

//Console.ReadKey();
//Console.ReadKey();
//Console.ReadKey();

//public struct Point 
//{
//	public int X {get; set; }
//	public int Y {get; set; }
	
//	public Point(int x, int y) 
//	{
//		X = x;
//		Y = Y;
//	}
	
//	public static Point operator + (Point p1, Point p2) 
//	{
//		return new Point(p1.X + p2.X, p1.Y + p2.Y);
//	}
//}

//class Program 
//{
//	static void Main() 
//	{
//		Point p1 = new Point(1,2);
//		Point p2 = new Point(3,4);
//		
//		Point p3 = p1 + p2;
//		
//		Console.WriteLine(p1,p2,p3);
//	}
//}

//using System;  
//using System.Collections.Generic;  
//using System.Linq;  
//public static class demo  
//{  
//    public static void Main()  
//    {  
//        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };  
//        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);  
  
//        foreach (var num in evenNumbers)  
//        {  
//            Console.Write("{0} ", num);  
//       }  
//        Console.WriteLine();  
//        Console.Read();  
  
//    }  
//}  

using System;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            SomeMethod();

            Console.WriteLine("Main Method End");
            Console.ReadLine();
        }

        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            //Thread.Sleep(TimeSpan.FromSeconds(10));
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\\n");
            Console.WriteLine("Some Method End");
        }
    }

//kode Console.WriteLine(Console.ReadLine()+Console.ReadLine());

//kode int a = int.Parse(Console.ReadLine());
//kode int b = int.Parse(Console.ReadLine());
//kode Console.WriteLine(a+b);

//Console.ReadKey();
//Console.ReadKey();
//Console.ReadKey();

public delegate void ResultCallback(int result);

public class Number 
{
	public int number;
	public ResultCallback resultCallback;
	
	public Number(int numberx, ResultCallback resultCallbackx) 
	{
		number = numberx;
		resultCallback = resultCallbackx;
	}
	
	public void Sum() 
	{
		int result = 0;
		for (int i=1;i<=number;i++) 
		{
			result = result + i;
		}
		
		if(resultCallback != null) 
		{
			resultCallback(result);
		}
	}
}

class MainProgram
{
	static void Main() 
	{
		ResultCallback myResultCallback = new ResultCallback(resultCallbackMethod);
		int number = 10;
		
		Number obj = new Number(number, myResultCallback);
		
		Thread t1 = new Thread(new ThreadStart(obj.Sum));
		t1.Start();
		Console.Read();
	}
	
	public static void resultCallbackMethod(int result) 
	{
		Console.WriteLine("The Result is "+ result);
	}
}
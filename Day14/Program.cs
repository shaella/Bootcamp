namespace DayFourteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            Console.WriteLine("Number 1:");
            int fourteenx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2:");
            int fourteenx2 = Convert.ToInt32(Console.ReadLine());
            int resultxx = fourteenx / fourteenx2;
 //           Console.WriteLine(resultxx);

            try
            {
                int resultxx = Convert.ToInt32(Console.ReadLine()) / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            finally
            {
                Console.WriteLine("Cleaning up resources...");
            }
        }
    }
}

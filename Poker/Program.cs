//using GameControllerLib;
using PlayerLib;
using CardLib;
using CardSuitLib;
using CardRankLib;
using RuleLib;
using IPlayerLib;

namespace Program
{
	public class Program
	{
		public static void Main(string[] args) 
		{
			Console.WriteLine(" --- Welcome to POKER game. ---");
			Console.WriteLine("There will be three players playing. Please enter your ID, name, and initial chips.");
			
			//GameController gamecontroller = new GameController();
			IPlayer player1 = new Player();
			Console.Write("Player 1, enter your ID: ");
			player1.SetID(Convert.ToInt32(Console.ReadLine()));
			player1.GetID();
			Console.Write("Player 1, enter your Name: ");
			player1.SetName(Convert.ToString(Console.ReadLine()));
			player1.GetName();
			Console.Write("Player 1, enter your initial chips: ");
			player1.SetChips(Convert.ToInt32(Console.ReadLine()));
			player1.GetChips();
			
			IPlayer player2 = new Player();
			Console.Write("Player 2, enter your ID: ");
			player2.SetID(Convert.ToInt32(Console.ReadLine()));
			player2.GetID();
			Console.Write("Player 2, enter your Name: ");
			player2.SetName(Convert.ToString(Console.ReadLine()));
			player2.GetName();
			Console.Write("Player 2, enter your initial chips: ");
			player2.SetChips(Convert.ToInt32(Console.ReadLine()));
			player2.GetChips();
			
			IPlayer player3 = new Player();
			Console.Write("Player 3, enter your ID: ");
			player3.SetID(Convert.ToInt32(Console.ReadLine()));
			player3.GetID();
			Console.Write("Player 3, enter your Name: ");
			player3.SetName(Convert.ToString(Console.ReadLine()));
			player3.GetName();
			Console.Write("Player 3, enter your initial chips: ");
			player3.SetChips(Convert.ToInt32(Console.ReadLine()));
			player3.GetChips();
			
			Console.WriteLine($"{player1.GetName}, Choose your option: [F]old, [C]heck, [B]et, [D]ial, [R]aise: ");
			char flop1 = Convert.ToChar(Console.ReadKey());
			switch (flop1) 
			{
				case 'F':
				Console.WriteLine("You have taken 'Fold' option.");
				break;
				case 'C':
				Console.WriteLine("You have taken 'Check' option.");
				break;
				case 'B':
				Console.WriteLine("You have taken 'Bet' option.");
				break;
				case 'D':
				Console.WriteLine("You have taken 'Dial' option.");
				break;
				case 'R':
				Console.WriteLine("You have taken 'Raise' option.");
				break;
			}							
		}
	}
}

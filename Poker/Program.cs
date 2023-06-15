using GameControllerLib;
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
			GameController gamecontroller = new GameController();
			IPlayer player1 = new Player();
			Console.Write("Player 1, enter your ID: ");
			player1.SetID(Convert.ToInt32(Console.ReadLine()));
			Console.WriteLine(player1.GetID());
			Console.Write("Player 1, enter your Name: ");
			player1.SetName(Convert.ToString(Console.ReadLine()));
			Console.WriteLine(player1.GetName());
			Console.Write("Player 1, enter your initial chips: ");
			player1.SetChips(Convert.ToInt32(Console.ReadLine()));
			Console.WriteLine(player1.GetChips());
			
			
		}
	}
}

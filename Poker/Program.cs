using System.Collections.Generic;
using GameControllerLib;
using BettingRoundLib;
using PlayerLib;
using CardBankLib;
using CardLib;
using CardSuitLib;
using CardRankLib;
using RuleLib;
using IPlayerLib;
using DisplayLib;

namespace Program
{
	public class Program
	{
		public static void Main(string[] args)
		{
//			Display display = new Display();
			GameController gamecontroller = new GameController();
			
//			IPlayer player1 = new Player();
//			Console.Write("Player 1, enter your name: ");
//			player1.SetName(Convert.ToString(Console.ReadLine()));
//			player1.GetName();
//			Console.Write(player1.GetName() + ", enter your ID: ");
//			player1.SetID(Convert.ToString(Console.ReadLine()));
//			player1.GetID();
//			Console.Write(player1.GetName() + ", enter your initial chips: ");
//			player1.SetChips(Convert.ToInt32(Console.ReadLine()));
//			gamecontroller.chips1 = player1.GetChips();

//			IPlayer player2 = new Player();
//			Console.Write("Player 2, enter your name: ");
//			player2.SetName(Convert.ToString(Console.ReadLine()));
//			player2.GetName();
//			Console.Write(player2.GetName() + ", enter your ID: ");
//			player2.SetID(Convert.ToString(Console.ReadLine()));
//			player2.GetID();
//			Console.Write(player2.GetName() + ", enter your initial chips: ");
//			player2.SetChips(Convert.ToInt32(Console.ReadLine()));
//			gamecontroller.chips2 = player2.GetChips();

//			IPlayer player3 = new Player();
//			Console.Write("Player 3, enter your name: ");
//			player3.SetName(Convert.ToString(Console.ReadLine()));
//			player3.GetName();
//			Console.Write(player3.GetName() + ", enter your ID: ");
//			player3.SetID(Convert.ToString(Console.ReadLine()));
//			player3.GetID();
//			Console.Write(player3.GetName() + ", enter your initial chips: ");
//			player3.SetChips(Convert.ToInt32(Console.ReadLine()));
//			gamecontroller.chips3 = player3.GetChips();

//			gamecontroller.GatherChips();
//			Console.WriteLine($"The collected chips from all players is {gamecontroller.allchips}");
//			Console.ReadLine();

			int numberOfPlayer = gamecontroller.GetPlayersCount();
			while (!gamecontroller.SetInputNumberOfPlayers(numberOfPlayer))
			{
			Console.Write("Enter the number of players (2-6): ");
			string input = Console.ReadLine();
			{
				if (int.TryParse(input, out numberOfPlayer) && gamecontroller.SetInputNumberOfPlayers(numberOfPlayer) == true)
				{
					Console.Clear();
					Console.WriteLine("Input number of players is successful");
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid number.");
				}
			}
//			return numberOfPlayer;
			}


			for (int i = 1; i <= numberOfPlayer; i++)
        		{
            		while (true)
            		{
                		Console.Write($"Enter the Name of Player {i}: (at least 2 characters): ");
                		string name = Console.ReadLine();
                		if (name.Length >= 2)
                		{
                    		gamecontroller.AddPlayer(name);
                    		break;
                		}
                		else
                		{
                   		 Console.WriteLine("Invalid input for player name. Try Again!");
                		}
			}
			}

			
			CardBank dealer = new CardBank();
			dealer.DealHoleCards();
//			dealer.BurnOneCard();

			BettingRound preflop = new BettingRound();
			preflop.StartBetting();
			preflop.StartBetting();
			preflop.StartBetting();
			Console.ReadLine();

			dealer.DealCommunityCards();

			BettingRound flop = new BettingRound();
			flop.StartBetting();
			flop.StartBetting();
			flop.StartBetting();
			Console.ReadLine();

			dealer.DealTurnCard();

			BettingRound turn = new BettingRound();
			turn.StartBetting();
			turn.StartBetting();
			turn.StartBetting();
			Console.ReadLine();

			dealer.DealRiverCard();

			BettingRound river = new BettingRound();
			river.StartBetting();
			river.StartBetting();
			river.StartBetting();
			Console.ReadLine();

			Console.ReadLine();
		}
	}
}

using GameControllerLib;
using BettingRoundLib;
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
            Console.WriteLine(" -------- Welcome to POKER game. --------");
            Console.WriteLine("There will be three players playing. Please enter your name, ID, and initial chips.");

            GameController gamecontroller = new GameController();
            IPlayer player1 = new Player();
            Console.Write("Player 1, enter your name: ");
            player1.SetName(Convert.ToString(Console.ReadLine()));
            player1.GetName();
            Console.Write(player1.GetName() + ", enter your ID: ");
            player1.SetID(Convert.ToString(Console.ReadLine()));
            player1.GetID();
            Console.Write(player1.GetName() + ", enter your initial chips: ");
            player1.SetChips(Convert.ToInt32(Console.ReadLine()));
            gamecontroller.chips1 = player1.GetChips();

            IPlayer player2 = new Player();
            Console.Write("Player 2, enter your name: ");
            player2.SetName(Convert.ToString(Console.ReadLine()));
            player2.GetName();
            Console.Write(player2.GetName() + ", enter your ID: ");
            player2.SetID(Convert.ToString(Console.ReadLine()));
            player2.GetID();
            Console.Write(player2.GetName() + ", enter your initial chips: ");
            player2.SetChips(Convert.ToInt32(Console.ReadLine()));
            gamecontroller.chips2 = player2.GetChips();

            IPlayer player3 = new Player();
            Console.Write("Player 3, enter your name: ");
            player3.SetName(Convert.ToString(Console.ReadLine()));
            player3.GetName();
            Console.Write(player3.GetName() + ", enter your ID: ");
            player3.SetID(Convert.ToString(Console.ReadLine()));
            player3.GetID();
            Console.Write(player3.GetName() + ", enter your initial chips: ");
            player3.SetChips(Convert.ToInt32(Console.ReadLine()));
            gamecontroller.chips3 = player3.GetChips();

	    gamecontroller.GatherChips();
            Console.WriteLine($"The collected chips from all players is {gamecontroller.allchips}");
	    Console.Read();
	    Console.WriteLine($"Dealing The Hole Cards to player . . .");
	    Console.ReadLine();

	    Console.WriteLine($"Burning one card . . .");
            Console.ReadLine();

	    BettingRound preflop = new BettingRound();
	    preflop.StartBetting();
	    preflop.StartBetting();
	    preflop.StartBetting();
	    Console.ReadLine();

	    Console.WriteLine($"Dealing The Flop to player . . .");
            Console.ReadLine();

	    BettingRound flop = new BettingRound();
	    flop.StartBetting();
            flop.StartBetting();
            flop.StartBetting();
	    Console.ReadLine();

	    Console.WriteLine($"Dealing The Turn to player . . .");
            Console.ReadLine();

	    BettingRound turn = new BettingRound();
            turn.StartBetting();
            turn.StartBetting();
            turn.StartBetting();
	    Console.ReadLine();

	    Console.WriteLine($"Dealing The River to player . . .");
            Console.ReadLine();

	    BettingRound river = new BettingRound();
            river.StartBetting();
            river.StartBetting();
            river.StartBetting();
	    Console.ReadLine();

	    Console.ReadLine();
        }
    }
}

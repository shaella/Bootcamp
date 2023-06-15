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
            Console.Write("Player 1, enter your name: ");
            player1.SetName(Convert.ToString(Console.ReadLine()));
            player1.GetName();
            Console.Write(player1.GetName() + ", enter your ID: ");
            player1.SetID(Convert.ToInt32(Console.ReadLine()));
            player1.GetID();
            Console.Write(player1.GetName() + ", enter your initial chips:");
            player1.SetChips(Convert.ToInt32(Console.ReadLine()));
            player1.GetChips();

            IPlayer player2 = new Player();
            Console.Write("Player 2, enter your name: ");
            player2.SetName(Convert.ToString(Console.ReadLine()));
            player2.GetName();
            Console.Write(player2.GetName() + ", enter your ID: ");
            player2.SetID(Convert.ToInt32(Console.ReadLine()));
            player2.GetID();
            Console.Write(player2.GetName() + ", enter your initial chips: ");
            player2.SetChips(Convert.ToInt32(Console.ReadLine()));
            player2.GetChips();

            IPlayer player3 = new Player();
            Console.Write("Player 3, enter your name: ");
            player3.SetName(Convert.ToString(Console.ReadLine()));
            player3.GetName();
            Console.Write(player3.GetName() + ", enter your ID: ");
            player3.SetID(Convert.ToInt32(Console.ReadLine()));
            player3.GetID();
            Console.Write(player3.GetName() + ", enter your initial chips: ");
            player3.SetChips(Convert.ToInt32(Console.ReadLine()));
            player3.GetChips();

            Console.Write(player1.GetName() + ", Choose your option: [F]old, [C]heck, [B]et, [D]ial, [R]aise: ");
            char flop1 = Convert.ToChar(Console.Read());
            switch (flop1)
            {
                case 'f':
                    Console.WriteLine("You have taken 'Fold' option.");
                    break;
                case 'c':
                    Console.WriteLine("You have taken 'Check' option. ");
                    break;
                case 'b':
                    Console.WriteLine("You have taken 'Bet' option.");
                    break;
                case 'd':
                    Console.WriteLine("You have taken 'Dial' option.");
                    break;
                case 'r':
                    Console.WriteLine("You have taken 'Raise' option.");
                    break;
            }

            Console.Write(player2.GetName() + ", Choose your option: [F]old, [C]heck, [B]et, [D]ial, [R]aise: ");
            char flop2 = Convert.ToChar(Console.ReadLine());
            switch (flop2)
            {
                case 'f':
                    Console.WriteLine("You have taken 'Fold' option.");
                    break;
                case 'c':
                    Console.WriteLine("You have taken 'Check' option. ");
                    break;
                case 'b':
                    Console.WriteLine("You have taken 'Bet' option.");
                    break;
                case 'd':
                    Console.WriteLine("You have taken 'Dial' option.");
                    break;
                case 'r':
                    Console.WriteLine("You have taken 'Raise' option.");
                    break;
            }

            Console.Write(player3.GetName() + ", Choose your option: [F]old, [C]heck, [B]et, [D]ial, [R]aise: ");
            char flop3 = Convert.ToChar(Console.Read());
            switch (flop3)
            {
                case 'f':
                    Console.WriteLine("You have taken 'Fold' option.");
                    break;
                case 'c':
                    Console.WriteLine("You have taken 'Check' option. ");
                    break;
                case 'b':
                    Console.WriteLine("You have taken 'Bet' option.");
                    break;
                case 'd':
                    Console.WriteLine("You have taken 'Dial' option.");
                    break;
                case 'r':
                    Console.WriteLine("You have taken 'Raise' option.");
                    break;
            }
        }
    }
}
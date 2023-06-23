using IPlayerLib;
using PlayerLib;
using CardLib;
using CardRankLib;
using CardSuitLib;
using RuleLib;
using ScoreLib;

namespace GameControllerLib
{
	class GameController
	{
		private IList<IPlayer> _players;
		private Dictionary<IPlayer, List<Card>> _holeCards;
		private List<Card> _tableCards;

		public GameController()
		{
			_players = new List<IPlayer>();
			_holeCards = new Dictionary<IPlayer, List<Card>>();
			_tableCards = new List<Card>();
		}

		public void CreatePlayers()
                {
                        Console.Write("Please enter the number of players (2-6): ");
                        int inputNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"OK. There will be {inputNumber} players playing.");
                        for (int i = 0; i < inputNumber; i++)
                        {
                                Console.WriteLine("Next player,");
                                Console.Write("Enter your name: ");
                                string names = Console.ReadLine();
                                Console.Write("Enter your ID: ");
                                string IDs = (Console.ReadLine());
                                _players.Add(new Player(names, IDs));
                        }
//                        foreach (var player in _players)
//                        {
//                                Console.WriteLine(player);
//                        }
                }		
	}
		
//		public int GatherChips()
//		{
//			return allchips = chips1 + chips2 + chips3;
//		}
}

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
		private Dictionary<IPlayer, List<Card>> _holeCards;
		private List<Card> _tableCards;
		public int allchips, chips1, chips2, chips3;

		public int GatherChips()
		{
			return allchips = chips1 + chips2 + chips3;
		}

//		public void BurnOneCard()
//		{
//			Console.WriteLine($"Burning one card . . .");
//                        Console.ReadLine();
//		}
		
//		public void DealHoleCards() 
//		{
//			Console.WriteLine($"Dealing The Hole Cards to player . . .");
//			Console.ReadLine();
//		}
		
//		public void DealCommunityCards()
//		{
//			Console.WriteLine($"Dealing The Flop to player . . .");
//			Console.ReadLine();
//		}
		
//		public void DealTurnCard() 
//		{
//			Console.WriteLine($"Dealing The Turn to player . . .");
//			Console.ReadLine();
//		}
		
//		public void DealRiverCard() 
//		{
//			Console.WriteLine($"Dealing The River to player . . .");
//			Console.ReadLine();
//		}


		//		public Dictionary<IPlayer, List<Card>> DealHoleCards()
		//		{
		//			for 

		//			Dictionary<IPlayer>, List<Card> 
		//		}
	}
}

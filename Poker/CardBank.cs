using System.Collections.Generic;
using CardLib;
using CardSuitLib;
using CardRankLib;
using GameControllerLib;
using IPlayerLib;
using PlayerLib;

namespace CardBankLib
{
	public class CardBank
	{
	//	public List<Card> GenerateCard() 
	//	{
	//		Random randomSuit = new Random();
	//		Array valuesSuit = Enum.GetValues(typeof(CardSuit));
	//		for(int i = 0; i < 10; i++)
	//		{
	//			int indexSuit = randomSuit.Next(valuesSuit.Length);
	//			CardSuit valuesuit = (CardSuit)valuesSuit.GetValue(indexSuit);
	
	//		}
	//		Random randomRank = new Random();
	//		Array valuesRank = Enum.GetValues(typeof(CardRank));
	//		for(int i = 0; i < 10; i++)
	//		{
	//			int indexRank = randomRank.Next(valuesRank.Length);
	//			CardSuit valuerank = (CardSuit)valuesRank.GetValue(indexRank);
	//		} 
	//	}
		
		public void DealHoleCards()
		{
//			GenerateCard();
			
			Console.WriteLine($"Dealing The Hole Cards to player . . .");
			Console.ReadLine();
		}

		public void DealCommunityCards()
		{
			Console.WriteLine($"Dealing The Flop to player . . .");
			Console.ReadLine();
		}

		public void DealTurnCard()
		{
			Console.WriteLine($"Dealing The Turn to player . . .");
			Console.ReadLine();
		}

		public void DealRiverCard()
		{
			Console.WriteLine($"Dealing The River to player . . .");
			Console.ReadLine();
		}
	}
}


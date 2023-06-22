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
		public Card GenerateCard() 
		{
			Random random = new Random();
			Array valuesSuit = Enum.GetValues(typeof(CardSuit));
			Array valuesRank = Enum.GetValues(typeof(CardRank));
			
			int indexSuit = random.Next(valuesSuit.Length);
			CardSuit tempSuit = (CardSuit)valuesSuit.GetValue(indexSuit);
			
			int indexRank = random.Next(valuesRank.Length);
			CardRank tempRank = (CardRank)valuesRank.GetValue(indexRank);
			
			return new Card(tempSuit,tempRank);
		}
		
		public void DealHoleCards()
		{
			Console.WriteLine("Dealing The Hole Cards to player . . .");
			GenerateCard();
			;
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


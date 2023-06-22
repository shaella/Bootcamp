using System.Collections.Generic;
using System.Linq;
using CardRankLib;
using CardSuitLib;

namespace CardLib
{
	public class Card
	{
		private string _cardname;
		private CardSuit _suit;
		private CardRank _rank;
		public string GetCardName()
		{
			return _cardname;
		}
		public CardSuit GetCardSuit() 
		{
			return _suit;
		}
		public CardRank GetCardRank()
		{
			return _rank;
		}
		public void SetCardName(string cardname)
		{
			_cardname = cardname;
		}
		public void SetCardSuit(CardSuit suit)
		{
			_suit = suit;
		}
		public void SetCardRank(CardRank rank)
		{
			_rank = rank;
		}
	}
}



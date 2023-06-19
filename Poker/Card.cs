using System.Collections.Generic;
using System.Linq;
using CardRankLib;
using CardSuitLib;

namespace CardLib
 {
	public class Card
	{
		public CardSuit suit;
		public CardRank rank;
//		public CardSuit GetCardSuit() 
//		{
//			return _suit;
//		}
//		public CardRank GetCardRank()
//		{
//			return _rank;
//		}
//		public void SetCardSuit(CardSuit suit)
//		{
//			_suit = suit;
//		}
//		public void SetCardRank(CardRank rank)
//		{
//			_rank = rank;
//		}
		public void GetCardSuit()
                {
			Random randomsuit = new Random();
                        Type typesuit = typeof(CardSuit);
                        Array valuessuit = typesuit.GetEnumValues();
                        int index = randomsuit.Next(valuessuit.Length);
                        CardSuit suit = (CardSuit)valuessuit.GetValue(index);
                }
                public void GetCardRank()
                {
                        Random randomrank = new Random();
                        Type typerank = typeof(CardRank);
                        Array valuesrank = typerank.GetEnumValues();
                        int index = randomrank.Next(valuesrank.Length);
                        CardRank rank = (CardRank)valuesrank.GetValue(index);
                }
	}
}



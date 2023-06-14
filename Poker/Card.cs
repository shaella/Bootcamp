using System.Collections.Generic;
using System.Linq;
using CardRankLib;
using CardSuitLib;

namespace CardLib
 {
	public class Card
	{
		private CardSuit _Suit;
		private CardRank _Rank;
		public CardSuit Suit
		{
			set
			{
				_Suit = Suit;
			}
			get
			{
				return _Suit;
			}
		}
		public CardRank Rank
		{
			set
			{
				_Rank = Rank;
			}
			get
			{
				return _Rank;
			}
		}
		
		public void GetCards() 
		{
			
			//Dictionary<CardSuit, CardRank> Cards = new Dictionary<CardSuit, CardRank> 
		//	List<CardRank> clubs = new List<CardRank>
		//	{
		//		{
		//			CardRank.Two,
		//			CardRank.Three,
 		//			CardRank.Four,
		//			CardRank.Five,
		//			CardRank.Six,
		//			CardRank.Seven,
		//			CardRank.Eight,
		//			CardRank.Nine,
		//			CardRank.Ten,
		//			CardRank.Jack,
		//			CardRank.Queen,
		//			CardRank.King,
		//			CardRank.Ace
		//		};
		} 
	}
}



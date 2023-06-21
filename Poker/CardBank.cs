using System.Collections.Generic;
using CardLib;
using CardSuitLib;
using CardRankLib;
using GameController;
using IPlayerLib;
using PlayerLib;

namespace CardBankLib
{
	public class CardBank
	{
		public List<Card> GenerateCard() 
		{
			Random randomSuit = new Random();
			Array valuesSuit = Enum.GetValues(typeof(CardSuit));
			for(int i = 0; i < 10; i++)
			{
				int indexSuit = randomsuit.Next(valuesSuit.Length);
				CardSuit valuesuit = (CardSuit)valuesSuit.GetValue(index);
			}
			Random randomRank = new Random();
			Array valuesRank = Enum.GetValues(typeof(CardRank));
			for(int i = 0; i < 10; i++)
			{
				int indexRank = randomRank.Next(valuesRank.Length);
				CardSuit valuerank = (CardSuit)valuesRank.GetValue(index);
			}
			return 
		}
		
//		public List<Card> GenerateDeck()
//		{
//			Card aceofclubs = new Card();
//			aceofclubs.cardname = "Ace of Clubs";
//			aceofclubs.rank = Enum.GetValues(typeof(CardRank.Ace));
//			aceofclubs.suit = CardSuit.Clubs;

//			Card kingofclubs = new Card();
//			kingofclubs.cardname = "King of Clubs";
//			kingofclubs.rank = Enum.GetValues(typeof(CardRank.King));
//			kingofclubs.suit = CardSuit.Clubs;

//			Card queenofclubs = new Card();
//			queenofclubs.cardname = "Queen of Clubs";
//			queenofclubs.rank = Enum.GetValues(typeof(CardRank.Queen));
//			queenofclubs.suit = CardSuit.Clubs;

//			Card jackofclubs = new Card();
//			jackofclubs.cardname = "Jack of Clubs";
//			jackofclubs.rank = Enum.GetValues(typeof(CardRank.Jack));
//			jackofclubs.suit = CardSuit.Clubs;

//			Card tenofclubs = new Card();
//			tenofclubs.cardname = "10 of Clubs";
//			tenofclubs.rank = Enum.GetValues(typeof(CardRank.Ten));
//			tenofclubs.suit = CardSuit.Clubs;

//			Card nineofclubs = new Card();
//			nineofclubs.cardname = "9 of Clubs";
//			nineofclubs.rank = Enum.GetValues(typeof(CardRank.Nine));
//			nineofclubs.suit = CardSuit.Clubs;

//			Card eightofclubs = new Card();
//			eightofclubs.cardname = "8 of Clubs";
//			eightofclubs.rank = Enum.GetValues(typeof(CardRank.Eight));
//			eightofclubs.suit = CardSuit.Clubs;

//			Card sevenofclubs = new Card();
//			sevenofclubs.cardname = "7 of Clubs";
//			sevenofclubs.rank = Enum.GetValues(typeof(CardRank.Seven));
//			sevenofclubs.suit = CardSuit.Clubs;

//			Card sixofclubs = new Card();
//			sixofclubs.cardname = "6 of Clubs";
//			sixofclubs.rank = Enum.GetValues(typeof(CardRank.Six));
//			sixofclubs.suit = CardSuit.Clubs;

//			Card fiveofclubs = new Card();
//			fiveofclubs.cardname = "5 of Clubs";
//			fiveofclubs.rank = Enum.GetValues(typeof(CardRank.Five));
//			fiveofclubs.suit = CardSuit.Clubs;

//			Card fourofclubs = new Card();
//			fourofclubs.cardname = "4 of Clubs";
//			fourofclubs.rank = Enum.GetValues(typeof(CardRank.Four));
//			fourofclubs.suit = CardSuit.Clubs;

//			Card threeofclubs = new Card();
//			threeofclubs.cardname = "3 of Clubs";
//			threeofclubs.rank = Enum.GetValues(typeof(CardRank.Three));
//			threeofclubs.suit = CardSuit.Clubs;

//			Card twoofclubs = new Card();
//			twoofclubs.cardname = "2 of Clubs";
//			twoofclubs.rank = Enum.GetValues(typeof(CardRank.Two));
//			twoofclubs.suit = CardSuit.Clubs;


//			Card aceofdiamonds = new Card();
//			aceofdiamonds.cardname = "Ace of Diamonds";
//			aceofdiamonds.rank = Enum.GetValues(typeof(CardRank.Ace));
//			aceofdiamonds.suit = CardSuit.Diamonds;

//			Card kingofdiamonds = new Card();
//			kingofdiamonds.cardname = "King of Diamonds";
//			kingofdiamonds.rank = Enum.GetValues(typeof(CardRank.King));
//			kingofdiamonds.suit = CardSuit.Diamonds;

//			Card queenofdiamonds = new Card();
//			queenofdiamonds.cardname = "Queen of Diamonds";
//			queenofdiamonds.rank = Enum.GetValues(typeof(CardRank.Queen));
//			queenofdiamonds.suit = CardSuit.Diamonds;

//			Card jackofdiamonds = new Card();
//			jackofdiamonds.cardname = "Jack of Diamonds";
//			jackofdiamonds.rank = Enum.GetValues(typeof(CardRank.Jack));
//			jackofdiamonds.suit = CardSuit.Diamonds;

//			Card tenofdiamonds = new Card();
//			tenofdiamonds.cardname = "10 of Diamonds";
//			tenofdiamonds.rank = Enum.GetValues(typeof(CardRank.Ten));
//			tenofdiamonds.suit = CardSuit.Diamonds;

//			Card nineofdiamonds = new Card();
//			nineofdiamonds.cardname = "9 of Diamonds";
//			nineofdiamonds.rank = Enum.GetValues(typeof(CardRank.Nine));
//			nineofdiamonds.suit = CardSuit.Diamonds;

//			Card eightofdiamonds = new Card();
//			eightofdiamonds.cardname = "8 of Diamonds";
//			eightofdiamonds.rank = Enum.GetValues(typeof(CardRank.Eight));
//			eightofdiamonds.suit = CardSuit.Diamonds;

//			Card sevenofdiamonds = new Card();
//			sevenofdiamonds.cardname = "7 of Diamonds";
//			sevenofdiamonds.rank = Enum.GetValues(typeof(CardRank.Seven));
//			sevenofdiamonds.suit = CardSuit.Diamonds;

//			Card sixofdiamonds = new Card();
//			sixofdiamonds.cardname = "6 of Diamonds";
//			sixofdiamonds.rank = Enum.GetValues(typeof(CardRank.Six));
//			sixofdiamonds.suit = CardSuit.Diamonds;

//			Card fiveofdiamonds = new Card();
//			fiveofdiamonds.cardname = "5 of Diamonds";
//			fiveofdiamonds.rank = Enum.GetValues(typeof(CardRank.Five));
//			fiveofdiamonds.suit = CardSuit.Diamonds;

//			Card fourofdiamonds = new Card();
//			fourofdiamonds.cardname = "4 of Diamonds";
//			fourofdiamonds.rank = Enum.GetValues(typeof(CardRank.Four));
//			fourofdiamonds.suit = CardSuit.Diamonds;

//			Card threeofdiamonds = new Card();
//			threeofdiamonds.cardname = "3 of Diamonds";
//			threeofdiamonds.rank = Enum.GetValues(typeof(CardRank.Three));
//			threeofdiamonds.suit = CardSuit.Diamonds;

//			Card twoofdiamonds = new Card();
//			twoofdiamonds.cardname = "2 of Diamonds";
//			twoofdiamonds.rank = Enum.GetValues(typeof(CardRank.Two));
//			twoofdiamonds.suit = CardSuit.Diamonds;


//			Card aceofhearts = new Card();
//			aceofhearts.cardname = "Ace of Hearts";
//			aceofhearts.rank = Enum.GetValues(typeof(CardRank.Ace));
//			aceofhearts.suit = CardSuit.Hearts;

//			Card kingofhearts = new Card();
//			kingofhearts.cardname = "King of Hearts";
//			kingofhearts.rank = Enum.GetValues(typeof(CardRank.King));
//			kingofhearts.suit = CardSuit.Hearts;

//			Card queenofhearts = new Card();
//			queenofhearts.cardname = "Queen of Hearts";
//			queenofhearts.rank = Enum.GetValues(typeof(CardRank.Queen));
//			queenofhearts.suit = CardSuit.Hearts;

//			Card jackofhearts = new Card();
//			jackofhearts.cardname = "Jack of Hearts";
//			jackofhearts.rank = Enum.GetValues(typeof(CardRank.Jack));
//			jackofhearts.suit = CardSuit.Hearts;

//			Card tenofhearts = new Card();
//			tenofhearts.cardname = "10 of Hearts";
//			tenofhearts.rank = Enum.GetValues(typeof(CardRank.Ten));
//			tenofhearts.suit = CardSuit.Hearts;

//			Card nineofhearts = new Card();
//			nineofhearts.cardname = "9 of Hearts";
//			nineofhearts.rank = Enum.GetValues(typeof(CardRank.Nine));
//			nineofhearts.suit = CardSuit.Hearts;

//			Card eightofhearts = new Card();
//			eightofhearts.cardname = "8 of Hearts";
//			eightofhearts.rank = Enum.GetValues(typeof(CardRank.Eight));
//			eightofhearts.suit = CardSuit.Hearts;

//			Card sevenofhearts = new Card();
//			sevenofhearts.cardname = "7 of Hearts";
//			sevenofhearts.rank = Enum.GetValues(typeof(CardRank.Seven));
//			sevenofhearts.suit = CardSuit.Hearts;

//			Card sixofhearts = new Card();
//			sixofhearts.cardname = "6 of Hearts";
//			sixofhearts.rank = Enum.GetValues(typeof(CardRank.Six));
//			sixofhearts.suit = CardSuit.Hearts;

//			Card fiveofhearts = new Card();
//			fiveofhearts.cardname = "5 of Hearts";
//			fiveofhearts.rank = Enum.GetValues(typeof(CardRank.Five));
//			fiveofhearts.suit = CardSuit.Hearts;

//			Card fourofhearts = new Card();
//			fourofhearts.cardname = "4 of Hearts";
//			fourofhearts.rank = Enum.GetValues(typeof(CardRank.Four));
//			fourofhearts.suit = CardSuit.Hearts;

//			Card threeofhearts = new Card();
//			threeofhearts.cardname = "3 of Hearts";
//			threeofhearts.rank = Enum.GetValues(typeof(CardRank.Three));
//			threeofhearts.suit = CardSuit.Hearts;

//			Card twoofhearts = new Card();
//			twoofhearts.cardname = "2 of Hearts";
//			twoofhearts.rank = Enum.GetValues(typeof(CardRank.Two));
//			twoofhearts.suit = CardSuit.Hearts;


//			Card aceofspades = new Card();
//			aceofspades.cardname = "Ace of Spades";
//			aceofspades.rank = Enum.GetValues(typeof(CardRank.Ace));
//			aceofspades.suit = CardSuit.Spades;

//			Card kingofspades = new Card();
//			kingofspades.cardname = "King of Spades";
//			kingofspades.rank = Enum.GetValues(typeof(CardRank.King));
//			kingofspades.suit = CardSuit.Spades;

//			Card queenofspades = new Card();
//			queenofspades.cardname = "Queen of Spades";
//			queenofspades.rank = Enum.GetValues(typeof(CardRank.Queen));
//			queenofspades.suit = CardSuit.Spades;

//			Card jackofspades = new Card();
//			jackofspades.cardname = "Jack of Spades";
//			jackofspades.rank = Enum.GetValues(typeof(CardRank.Jack));
//			jackofspades.suit = CardSuit.Spades;

//			Card tenofspades = new Card();
//			tenofspades.cardname = "10 of Spades";
//			tenofspades.rank = Enum.GetValues(typeof(CardRank.Ten));
//			tenofspades.suit = CardSuit.Spades;

//			Card nineofspades = new Card();
//			nineofspades.cardname = "9 of Spades";
//			nineofspades.rank = Enum.GetValues(typeof(CardRank.Nine));
//			nineofspades.suit = CardSuit.Spades;

//			Card eightofspades = new Card();
//			eightofspades.cardname = "8 of Spades";
//			eightofspades.rank = Enum.GetValues(typeof(CardRank.Eight));
//			eightofspades.suit = CardSuit.Spades;

//			Card sevenofspades = new Card();
//			sevenofspades.cardname = "7 of Spades";
//			sevenofspades.rank = Enum.GetValues(typeof(CardRank.Seven));
//			sevenofspades.suit = CardSuit.Spades;

//			Card sixofspades = new Card();
//			sixofspades.cardname = "6 of Spades";
//			sixofspades.rank = Enum.GetValues(typeof(CardRank.Six));
//			sixofspades.suit = CardSuit.Spades;

//			Card fiveofspades = new Card();
//			fiveofspades.cardname = "5 of Spades";
//			fiveofspades.rank = Enum.GetValues(typeof(CardRank.Five));
//			fiveofspades.suit = CardSuit.Spades;

//			Card fourofspades = new Card();
//			fourofspades.cardname = "4 of Spades";
//			fourofspades.rank = Enum.GetValues(typeof(CardRank.Four));
//			fourofspades.suit = CardSuit.Spades;

//			Card threeofspades = new Card();
//			threeofspades.cardname = "3 of Spades";
//			threeofspades.rank = Enum.GetValues(typeof(CardRank.Three));
//			threeofspades.suit = CardSuit.Spades;

//			Card twoofspades = new Card();
//			twoofspades.cardname = "2 of Spades";
//			twoofspades.rank = Enum.GetValues(typeof(CardRank.Two));
//			twoofspades.suit = CardSuit.Spades;
			
//			List<Card> deck = new List<CardBank> 
//			{
//				aceofclubs, aceofdiamonds, aceofhearts, aceofspades,
//				twoofclubs, twoofdiamonds, twoofhearts, twoofspades,
//				threeofclubs, threeofdiamonds, threeofhearts, threeofspades,
//				fourofclubs, fourofdiamonds, fourofhearts, fourofspades,
//				fiveofclubs, fiveofdiamonds, fiveofhearts, fiveofspades,
//				sixofclubs, sixofdiamonds, sixofhearts, sixofspades,
//				sevenofclubs, sevenofdiamonds, sevenofhearts, sevenofspades,
//				eightofclubs, eightofdiamonds, eightofhearts, eightofspades,
//				nineofclubs, nineofdiamonds, nineofhearts, nineofspades,
//				tenofclubs, tenofdiamonds, tenofhearts, tenofspades,
//				jackofclubs, jackofdiamonds, jackofhearts, jackofspades,
//				queenofclubs, queenofdiamonds, queenofhearts, queenofspades,
//				kingofclubs, kingofdiamonds, kingofhearts, kingofspades
//			};
			
//		}
//		public void BurnOneCard()
//		{
//			Console.WriteLine($"Burning one card . . .");
//			Console.ReadLine();
//		}

		public void DealHoleCards()
		{
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


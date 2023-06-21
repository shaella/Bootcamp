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
		public List<Card> GenerateDeck()
		{
			Card aceofclubs = new Card();
			aceofclubs.cardname = "Ace of Clubs";
			aceofclubs.rank = 14;
			aceofclubs.suit = CardSuit.Clubs;

			Card kingofclubs = new Card();
                        kingofclubs.cardname = "King of Clubs";
                        kingofclubs.rank = 13;
                        kingofclubs.suit = CardSuit.Clubs;

			Card queenofclubs = new Card();
                        queenofclubs.cardname = "Queen of Clubs";
                        queenofclubs.rank = 12;
                        queenofclubs.suit = CardSuit.Clubs;

			Card jackofclubs = new Card();
                        jackofclubs.cardname = "Jack of Clubs";
                        jackofclubs.rank = 11;
                        jackofclubs.suit = CardSuit.Clubs;

			Card tenofclubs = new Card();
                        tenofclubs.cardname = "10 of Clubs";
                        tenofclubs.rank = 10;
                        tenofclubs.suit = CardSuit.Clubs;

			Card nineofclubs = new Card();
                        nineofclubs.cardname = "9 of Clubs";
                        nineofclubs.rank = 9;
                        nineofclubs.suit = CardSuit.Clubs;

			Card eightofclubs = new Card();
                        eightofclubs.cardname = "8 of Clubs";
                        eightofclubs.rank = 8;
                        eightofclubs.suit = CardSuit.Clubs;

			Card sevenofclubs = new Card();
                        sevenofclubs.cardname = "7 of Clubs";
                        sevenofclubs.rank = 7;
                        sevenofclubs.suit = CardSuit.Clubs;

			Card sixofclubs = new Card();
                        sixofclubs.cardname = "6 of Clubs";
                        sixofclubs.rank = 6;
                        sixofclubs.suit = CardSuit.Clubs;

			Card fiveofclubs = new Card();
                        fiveofclubs.cardname = "5 of Clubs";
                        fiveofclubs.rank = 5;
                        fiveofclubs.suit = CardSuit.Clubs;

			Card fourofclubs = new Card();
                        fourofclubs.cardname = "4 of Clubs";
                        fourofclubs.rank = 4;
                        fourofclubs.suit = CardSuit.Clubs;

			Card threeofclubs = new Card();
                        threeofclubs.cardname = "3 of Clubs";
                        threeofclubs.rank = 3;
                        threeofclubs.suit = CardSuit.Clubs;

			Card twoofclubs = new Card();
                        twoofclubs.cardname = "2 of Clubs";
                        twoofclubs.rank = 2;
                        twoofclubs.suit = CardSuit.Clubs;


			Card aceofdiamonds = new Card();
			aceofdiamonds.cardname = "Ace of Diamonds";
			aceofdiamonds.rank = 14;
			aceofdiamonds.suit = CardSuit.Diamonds;

			Card kingofdiamonds = new Card();
                        kingofdiamonds.cardname = "King of Diamonds";
                        kingofdiamonds.rank = 13;
                        kingofdiamonds.suit = CardSuit.Diamonds;

			Card queenofdiamonds = new Card();
                        queenofdiamonds.cardname = "Queen of Diamonds";
                        queenofdiamonds.rank = 12;
                        queenofdiamonds.suit = CardSuit.Diamonds;

			Card jackofdiamonds = new Card();
                        jackofdiamonds.cardname = "Jack of Diamonds";
                        jackofdiamonds.rank = 11;
                        jackofdiamonds.suit = CardSuit.Diamonds;

			Card tenofdiamonds = new Card();
                        tenofdiamonds.cardname = "10 of Diamonds";
                        tenofdiamonds.rank = 10;
                        tenofdiamonds.suit = CardSuit.Diamonds;

			Card nineofdiamonds = new Card();
                        nineofdiamonds.cardname = "9 of Diamonds";
                        nineofdiamonds.rank = 9;
                        nineofdiamonds.suit = CardSuit.Diamonds;

			Card eightofdiamonds = new Card();
                        eightofdiamonds.cardname = "8 of Diamonds";
                        eightofdiamonds.rank = 8;
                        eightofdiamonds.suit = CardSuit.Diamonds;

			Card sevenofdiamonds = new Card();
                        sevenofdiamonds.cardname = "7 of Diamonds";
                        sevenofdiamonds.rank = 7;
                        sevenofdiamonds.suit = CardSuit.Diamonds;

			Card sixofdiamonds = new Card();
                        sixofdiamonds.cardname = "6 of Diamonds";
                        sixofdiamonds.rank = 6;
                        sixofdiamonds.suit = CardSuit.Diamonds;

			Card fiveofdiamonds = new Card();
                        fiveofdiamonds.cardname = "5 of Diamonds";
                        fiveofdiamonds.rank = 5;
                        fiveofdiamonds.suit = CardSuit.Diamonds;

			Card fourofdiamonds = new Card();
                        fourofdiamonds.cardname = "4 of Diamonds";
                        fourofdiamonds.rank = 4;
                        fourofdiamonds.suit = CardSuit.Diamonds;

			Card threeofdiamonds = new Card();
                        threeofdiamonds.cardname = "3 of Diamonds";
                        threeofdiamonds.rank = 3;
                        threeofdiamonds.suit = CardSuit.Diamonds;

			Card twoofdiamonds = new Card();
                        twoofdiamonds.cardname = "2 of Diamonds";
                        twoofdiamonds.rank = 2;
                        twoofdiamonds.suit = CardSuit.Diamonds;


			Card aceofhearts = new Card();
			aceofhearts.cardname = "Ace of Hearts";
			aceofhearts.rank = 14;
			aceofhearts.suit = CardSuit.Hearts;

			Card kingofhearts = new Card();
                        kingofhearts.cardname = "King of Hearts";
                        kingofhearts.rank = 13;
                        kingofhearts.suit = CardSuit.Hearts;

			Card queenofhearts = new Card();
                        queenofhearts.cardname = "Queen of Hearts";
                        queenofhearts.rank = 12;
                        queenofhearts.suit = CardSuit.Hearts;

			Card jackofhearts = new Card();
                        jackofhearts.cardname = "Jack of Hearts";
                        jackofhearts.rank = 11;
                        jackofhearts.suit = CardSuit.Hearts;

			Card tenofhearts = new Card();
                        tenofhearts.cardname = "10 of Hearts";
                        tenofhearts.rank = 10;
                        tenofhearts.suit = CardSuit.Hearts;

			Card nineofhearts = new Card();
                        nineofhearts.cardname = "9 of Hearts";
                        nineofhearts.rank = 9;
                        nineofhearts.suit = CardSuit.Hearts;

			Card eightofhearts = new Card();
                        eightofhearts.cardname = "8 of Hearts";
                        eightofhearts.rank = 8;
                        eightofhearts.suit = CardSuit.Hearts;

			Card sevenofhearts = new Card();
                        sevenofhearts.cardname = "7 of Hearts";
                        sevenofhearts.rank = 7;
                        sevenofhearts.suit = CardSuit.Hearts;

			Card sixofhearts = new Card();
                        sixofhearts.cardname = "6 of Hearts";
                        sixofhearts.rank = 6;
                        sixofhearts.suit = CardSuit.Hearts;

			Card fiveofhearts = new Card();
                        fiveofhearts.cardname = "5 of Hearts";
                        fiveofhearts.rank = 5;
                        fiveofhearts.suit = CardSuit.Hearts;

			Card fourofhearts = new Card();
                        fourofhearts.cardname = "4 of Hearts";
                        fourofhearts.rank = 4;
                        fourofhearts.suit = CardSuit.Hearts;

			Card threeofhearts = new Card();
                        threeofhearts.cardname = "3 of Hearts";
                        threeofhearts.rank = 3;
                        threeofhearts.suit = CardSuit.Hearts;

			Card twoofhearts = new Card();
                        twoofhearts.cardname = "2 of Hearts";
                        twoofhearts.rank = 2;
                        twoofhearts.suit = CardSuit.Hearts;


			Card aceofclubs = new Card();
			aceofclubs.cardname = "Ace of Clubs";
			aceofclubs.rank = 14;
			aceofclubs.suit = CardSuit.Clubs;

			Card kingofclubs = new Card();
                        kingofclubs.cardname = "King of Clubs";
                        kingofclubs.rank = 13;
                        kingofclubs.suit = CardSuit.Clubs;

			Card queenofclubs = new Card();
                        queenofclubs.cardname = "Queen of Clubs";
                        queenofclubs.rank = 12;
                        queenofclubs.suit = CardSuit.Clubs;

			Card jackofclubs = new Card();
                        jackofclubs.cardname = "Jack of Clubs";
                        jackofclubs.rank = 11;
                        jackofclubs.suit = CardSuit.Clubs;

			Card tenofclubs = new Card();
                        tenofclubs.cardname = "10 of Clubs";
                        tenofclubs.rank = 10;
                        tenofclubs.suit = CardSuit.Clubs;

			Card nineofclubs = new Card();
                        nineofclubs.cardname = "9 of Clubs";
                        nineofclubs.rank = 9;
                        nineofclubs.suit = CardSuit.Clubs;

			Card eightofclubs = new Card();
                        eightofclubs.cardname = "8 of Clubs";
                        eightofclubs.rank = 8;
                        eightofclubs.suit = CardSuit.Clubs;

			Card sevenofclubs = new Card();
                        sevenofclubs.cardname = "7 of Clubs";
                        sevenofclubs.rank = 7;
                        sevenofclubs.suit = CardSuit.Clubs;

			Card sixofclubs = new Card();
                        sixofclubs.cardname = "6 of Clubs";
                        sixofclubs.rank = 6;
                        sixofclubs.suit = CardSuit.Clubs;

			Card fiveofclubs = new Card();
                        fiveofclubs.cardname = "5 of Clubs";
                        fiveofclubs.rank = 5;
                        fiveofclubs.suit = CardSuit.Clubs;

			Card fourofclubs = new Card();
                        fourofclubs.cardname = "4 of Clubs";
                        fourofclubs.rank = 4;
                        fourofclubs.suit = CardSuit.Clubs;

			Card threeofclubs = new Card();
                        threeofclubs.cardname = "3 of Clubs";
                        threeofclubs.rank = 3;
                        threeofclubs.suit = CardSuit.Clubs;

			Card twoofclubs = new Card();
                        twoofclubs.cardname = "2 of Clubs";
                        twoofclubs.rank = 2;
                        twoofclubs.suit = CardSuit.Clubs;

			



		}
		public void BurnOneCard()
                {
                        Console.WriteLine($"Burning one card . . .");
                        Console.ReadLine();
                }

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


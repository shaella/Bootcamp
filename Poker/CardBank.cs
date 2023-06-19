using System.Collections.Generic;
using CardLib;
using CardSuitLib;
using CardRankLib;
using IPlayerLib;
using PlayerLib;

namespace CardBankLib
{
	public class CardBank
	{
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


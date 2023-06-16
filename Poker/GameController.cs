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
		private List<IPlayer> _players;
		private Dictionary<IPlayer, List<Card>> _holeCards;
		private List<Card> _tableCards;
		public int allchips, chips1, chips2, chips3;

		public int GatherChips()
                {
                        return allchips = chips1+chips2+chips3;
                }

//		public Dictionary<IPlayer, List<Card>> DealHoleCards()
//		{
//			for 
			
//			Dictionary<IPlayer>, List<Card> 
//		}
	}
}

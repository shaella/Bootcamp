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
		private List<Player> _players;
		private Dictionary<IPlayer, List<holeCard>> __playersCards;
		private List<communityCards> _communityCards;
		private List<Card> _deck;
		private Rule _rules;
	}
}

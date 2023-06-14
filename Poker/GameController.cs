using IPlayer;
using Player;
using Card;
using CardRank;
using CardSuit;
using Rule;
using Score;

namespace GameControllerN
{
	class GameController
	{
		private List<Player> _players;
		private Dictionary<IPlayer, List<holeCard> __playersCards;
		private List<communityCards> _communityCards;
		private List<Card> _deck;
		private Rule _rules;

}

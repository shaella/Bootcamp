using IPlayerLib;
using PlayerLib;
using CardBankLib;
using CardLib;
using CardRankLib;
using CardSuitLib;
using RuleLib;
using ScoreLib;
 
namespace GameControllerLib
{
	class GameController
	{
		private IList<IPlayer> _players;
		private Dictionary<IPlayer, List<Card>> _holeCards;
		private List<Card> _tableCards;

		public GameController()
		{
			_players = new List<IPlayer>();
			_holeCards = new Dictionary<IPlayer, List<Card>>();
			_tableCards = new List<Card>();
		}

		public IPlayer GetPlayer(string name)
		{
			return _players.FirstOrDefault(player => player.GetName() == name);
		}

		public bool SetInputNumberOfPlayers(int numberOfPlayers)
		{  
			if (numberOfPlayers >= 2 && numberOfPlayers <= 6)
			{
				return true;
			}
			return false;
		}

		public bool AddPlayer(string name)
		{
			if (string.IsNullOrEmpty(name) || _players.Any(player => player.GetName() == name))
			{
				return false;
			}
			_players.Add(new Player());
			return true;
		}

		public bool SetPlayers(IList<IPlayer> players)
		{
			if (players.Count >=2 && players.Count <= 4)
			{
				_players = players;
				return true;
			}
			return false;
		}

		public IList<IPlayer> GetPlayers()
		{
			return _players;
		}

		public int GetPlayersCount()
		{
			return _players.Count();
		}

		public bool SetPlayerName(IPlayer player, string name)
		{
			if (GetPlayersCount() != null && name.Length > 2)
			{
			player.SetName(name);
			return true;
			}
		return false;
		}

		public string GetPlayerName(IPlayer player)
		{
			if (player != null)
			{
				return player.GetName();
			}
			return string.Empty;
		}

		public string GetPlayerID(IPlayer player)
		{
			if (player != null)
			{
				return player.GetID();
			}
			return string.Empty;
		}
	}
		
//		public int GatherChips()
//		{
//			return allchips = chips1 + chips2 + chips3;
//		}
}

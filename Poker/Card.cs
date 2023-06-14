public class Card
{
	private CardSuit _Suit;
	private CardRank _Rank;
	public CardSuit Suit
	{
		set
		{
			_Suit = value;
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
			_Rank = value;
		}
		get
		{
			return _Rank;
		}
	}
}

using System.Collections.Generic;

namespace ScoreLib
{
	public enum Score : int
	{
		NoPair = 0,
		OnePair = 26,
		TwoPairs = 52,
		ThreeOfAKind = 39,
		Straight = 65,
		Flush = 100,
		FullHouse = 63,
		FourOfAKind = 152,
		StraightFlush = 155
	}
}


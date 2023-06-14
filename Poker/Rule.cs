using CardLib;
using CardSuitLib;
using CardRankLib;

namespace RuleLib
{
	public class Rule
	{
		string result;
		public void ObtainResult()
		{
			switch (result) 
			{
				case "straightflush":
				result = "straightflush";
				break;
				case "fourofakind":
				result = "fourofakind";
				break;
				case "fullhouse":
				result = "fullhouse";
				break;
				case "flush":
				result = "flush";
				break;
				case "staright":
				result = "straight";
				break;
				case "threeofakind":
				result = "threeofakind";
				break;
				case "twopairs":
				result = "twopairs";
				break;
				case "onepair":
				result = "onepair";
				break;
				default:
				result = "nopair";
				break;
			}	
		}
	}
}


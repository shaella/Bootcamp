using IPlayerLib;
namespace PlayerLib
{
	public class Player : IPlayer
	{
		private string _ID;
		private string _name;
		private int _chips;
		public string GetID()
		{
			return _ID;
		}
		public string GetName()
		{
			return _name;
		}
		public int GetChips() 
		{
			return _chips;
		}
		public void SetChips(int chips)
		{
			_chips = chips;		
		}
		public void SetName(string name) 
		{
			_name = name;
		}
		public void SetID(string ID) 
		{
			_ID = ID;
		}
	}
}


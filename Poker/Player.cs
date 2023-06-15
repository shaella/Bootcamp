using IPlayerLib;
namespace PlayerLib
{
	public class Player : IPlayer
	{
		private int _ID;
		private string _name;
		private int _chips;
		public int GetID()
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
			_chips = _chips;		
		}
		public void SetName(string name) 
		{
			_name = name;
		}
		public void SetID(int ID) 
		{
			_ID = ID;
		}
	}
}


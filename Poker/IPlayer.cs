namespace IPlayerLib
{
	public interface IPlayer
	{
		int GetID();
		void SetID(int ID);
		string GetName();
		void SetName(string name);
		int GetChips();
		void SetChips(int chips);
	}
}

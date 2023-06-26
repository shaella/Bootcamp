namespace IPlayerLib
{
	public interface IPlayer
	{
		string GetID();
		void SetID(string ID);
		string GetName();
		void SetName(string name);
		int GetChips();
		void SetChips(int chips);
	}
}

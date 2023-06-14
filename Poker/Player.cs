using IPlayerLib;
namespace PlayerLib
public class Player : IPlayer
{
	private int _ID;
	private	string _name;
	private int _chips;
	public int ID
	{
		set
		{
			_ID = id;
		}
		get
		{
			return _ID;
		}
	}
	public string name
	{
		set
		{
			_name = name;
		}
		get
		{
			return _name;
		}
	}
	public int chips
	{
		set
		{
			_chips = chips;
		}
		get
		{
			return _chips;
		}
	}
	
	
}
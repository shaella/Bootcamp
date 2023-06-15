namespace tesPOKER 
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
			_chips = chips;		
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
	
	class Program 
	{
		public static void Main(string[] args) 
		{
			//GameController gamecontroller = new GameController();
			
			IPlayer player1 = new Player();
			Console.Write("Player 1, enter your ID: ");
			player1.SetID(Convert.ToInt32(Console.ReadLine()));
			Console.WriteLine(player1.GetID());
			Console.Write("Player 1, enter your Name: ");
			player1.SetName(Convert.ToString(Console.ReadLine()));
			Console.WriteLine(player1.GetName());
			Console.Write("Player 1, enter your initial chips: ");
			player1.SetChips(Convert.ToInt32(Console.ReadLine()));
			Console.WriteLine(player1.GetChips());
		}
	}	
}		
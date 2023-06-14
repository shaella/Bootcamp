using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DayTwenty
{
	[Serializable]
	public class Room 
	{
		public int  desks {get; set;}
		public int chairs {get; set;} 
		public int people {get; set;}
	}
	class Program 
	{
		static void Main(string[] args)
		{
			//Serialization
			Room myRoom = new Room{desks = 10, chairs = 10, people = 8};
			FileStream myStream = new FileStream("myRoom.json", FileMode.Create);
			BinaryFormatter myFormatter = new BinaryFormatter();
			myFormatter.Serialize(myStream, myRoom);
			myStream.Close();
			
			//Deserialization
			Stream myStreamDe = new FileStream("myRoom.json", FileMode.Open);
			BinaryFormatter myFormatterDe = new BinaryFormatter();
			myRoom myRoomDe = (myRoom)myFormatterDe.Deserialize(myStreamDe);
			myStreamDe.Close();
		}
	}
}
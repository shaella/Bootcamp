namespace samplePrototype
{
	public class Doll: Toy
	{
		public string material { get; set; }
	
		public override Toy ProduceClone()
		{
			return (Doll)this.MemberwiseClone();
		}

		public override void GetInfo()
		{
			Console.WriteLine("Doll");
			Console.WriteLine($" Model:{this.model}, Target: {this.target}, Level: {this.level}, Material: {this.material}\n");
		}
	}
}

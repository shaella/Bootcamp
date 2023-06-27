namespace samplePrototype
{
	public abstract class Toy
	{
		public string model { get; set; }
		public string target { get; set; }
		public string level { get; set; }

		public abstract Toy ProduceClone();
		public abstract void GetInfo();
	}
}

namespace samplePrototype
{
        public class Puzzle: Toy
        {                  
                public int item { get; set; }
        
                public override Toy ProduceClone()
                {
                        return (Toy)this.MemberwiseClone();
                }

		public override void GetInfo()
                {
                        Console.WriteLine("Puzzle");
                        Console.WriteLine($" Model:{this.model}, Target: {this.target}, Level: {this.level}, Total Item: {this.item}\n");
                }
        }
}

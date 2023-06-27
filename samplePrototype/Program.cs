namespace samplePrototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Toy teddybear = new Doll()
			{
				model = "bear",
				target = "all",
				level = "easy",
				material = "fur"
			};

			Toy matryoshka = teddybear.ProduceClone();
			matryoshka.model = "woman";
			//matryoshka.material = "wood";
			
			teddybear.GetInfo();
			matryoshka.GetInfo();

			Toy rubik = new Puzzle()
			{
				model = "3D",
				target = "all",
				level = "hard",
				item = 27
			};

			Toy sudoku = rubik.ProduceClone();
			sudoku.model = "2D";
			rubik.GetInfo();
			sudoku.GetInfo();

			//WITHOUT PROTOTYPE
			Console.WriteLine("\n\nCopying object without Prototype");
			Toy puzzleboard = new Puzzle()
			{
				model = "2D",
				      target = "all",
				      level = "hard",
				      item = 101
			};
			Console.WriteLine("Before copying ... :");
			puzzleboard.GetInfo();
			Toy tetris = puzzleboard;
			tetris.target = "adult";
			tetris.level = "very hard";
			Console.WriteLine("TETRIS");
			tetris.GetInfo();
			Console.WriteLine("PUZZLEBOARD");
			puzzleboard.GetInfo();
		}
	}
}



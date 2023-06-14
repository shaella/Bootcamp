class Program 
{
	static void Main() 
	{
		string aaa = @"C:\Users\Batch 2\Documents\catatanBootcamp\work\newdir";
		
		Directory.CreateDirectory(aaa);
 		
		if (Directory.Exists(aaa)) 
		{
			Console.WriteLine("Directory exist.");
		}
		
		string bbb = Path.Combine(aaa, "newfile");
		File.WriteAllText(bbb, "5*2=10");
		string eee = Path.Combine(aaa, "newfile.txt");
		File.WriteAllText(eee, "5*2=10");
		
		string ccc = @"C:\Users\Batch 2\Documents\catatanBootcamp\work\newdir";
		string[] ddd = Directory.GetFiles(ccc);
		foreach (string file in ddd) 
		{
			Console.WriteLine(file);
		}
		
//		using (FileStream filestream = new FileStream(eee, FileAccess.Read)) 
//		{
//			byte[] buffer = new byte[filestream.Length]; //f s.Length is the size of the file
//           filestream.Read(buffer, 0, buffer.Length); //buffer, offset, count
//            string content = System.Text.Encoding.UTF8.GetString(buffer);
//		} 
	}
}

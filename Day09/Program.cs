//Hari ke-9,
//*String and Text Handling, Date and Times, Utility Classes, Enums
using System.Diagnostics;
namespace hsembilan 
{
	class Program 
	{
		static void Main(string[] args) 
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.BackgroundColor = ConsoleColor.White;
			string title = "Hari ini";
			int tanggal = 26;
			Months bulan = Months.Mei;
			Activities apygdilakukan = Activities.BelajarCSharp;
			Stopwatch waktu = new Stopwatch();
			waktu.Start();
			for(int i = 0; i <= 9000; i++)
			{
				int nomor = 30;
			}
			waktu.Stop();
			Console.WriteLine($"untuk menghitung nomor sampai ke-30, komputer ini membutuhkan waktu {waktu.ElapsedMilliseconds} milidetik");
			TimeSpan durasi = waktu.Elapsed;
			Console.WriteLine(durasi); 
			
			string kalimat = $"title punya {title.Length} karakter: {title[0]}, {title[1]}, {title[2]}, {title[3]}, {title[4]}, <spasi>, {title[6]}, {title[7]}, dibaca 'Hari ini'";
			Console.WriteLine(kalimat.ToUpper());
			string[] xkatax = kalimat.Split(' ');
			foreach (char kata in kalimat) 
			{
				Console.WriteLine(kata + "#");
			}
			Console.WriteLine($"{title} tanggal {tanggal} {bulan} saya {apygdilakukan}");
		
		}
	}
}

public enum Months 
{
	Januari,
	Februari,
	Maret,
	April,
	Mei,
	Juni,
	Juli,
	Agustus,
	September,
	Oktober,
	November,
	Desember
}

public enum Activities 
{
	BelajarCSharp,
	BelajarGit,
	UnggahHasilKaryaKeGitHub
}

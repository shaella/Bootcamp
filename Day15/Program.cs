//Hari ke-9,
//*String and Text Handling

namespace hsembilan 
{
	class Program 
	{
		static void Main(string[] args) 
		{
			string title = "Hari ini";
			int tanggal = 26;
			Months bulan = Months.Mei;
			Activities apygdilakukan = Activities.BelajarCSharp;
			
			string kalimat = Convert.ToString($"title punya {title.Length} karakter: {title[0]}, {title[1]}, {title[2]}, {title[3]}, {title[4]}, <spasi>, {title[6]}, {title[7]}, dibaca 'Hari ini'");
			string KALIMAT = kalimat.ToUpper();
			Console.WriteLine(KALIMAT);
			string[] xkatax = kalimat.Split(' ');
			foreach (char kata in kalimat) 
			{
				Console.WriteLine(kata + "#");
			}
		
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

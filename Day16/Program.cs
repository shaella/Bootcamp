// CHECK: Array (OK), Dictionary (OK), ArrayList:Clone, CopyTo (OK)
//Array Class

using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ShArrayDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Hewan hdindo = new Hewan("komodo");
			Hewan hdpadangurun = new Hewan("unta");
			Hewan hdaustralia = new Hewan("kanguru");
			Hewan hdamerikaselatan = new Hewan("piranha");

			Hewan[] hunikddunia = { hdindo, hdpadangurun, hdaustralia, hdamerikaselatan };
			Hewan[] hunikddunia2 = new Hewan[4];
			hunikddunia2[0] = hdindo;
			hunikddunia2[1] = hdaustralia;
			hunikddunia2[2] = hdamerikaselatan;
			hunikddunia2[3] = hdpadangurun;

//			Console.WriteLine($"1 Hewan unik di Indonesia = {Hewan[0].Name}");

			//Console.WriteLine(hewandarat == hewanberkakiempat);
			//Console.WriteLine(hewandarat.Equals(hewanberkakiempat));
			//IStructuralEquatable se1 = hewandarat;
			//Console.WriteLine(se1 = hewandarat[1]);
			//Console.WriteLine(se1.Equals(hewandarat, StructuralComparisons.StructuralEqualityComparer));

//			for (int i = 0; i <= hunikddunia.Length - 1; i++)
//			{
//				Console.WriteLine($"Hewan unik di dunia [{i}] = {hunikddunia[i].Name}");
//			}

			//Array atributkambing = Array.CreateInstance(typeof(string), 4);
			//atributkambing.SetValue = ("kepala", 0);
			//atributkambing.SetValue = ("kaki", 1);
			//atributkambing.SetValue = ("perut", 2);
			//atributkambing.SetValue = ("ekor", 3);
			//string atrkambings = (string)atributkambing.GetValue(0);
			//string[] cSharpArray = (string[])atributkambing;
			//string atrkambings2 = cSharpArray[1];
			
			//DICTIONARY
			Dictionary <string, string> dicthewan = new Dictionary <string, string> ();
			dicthewan.Add("berkaki empat", "kambing, anjing, domba");
			dicthewan.Add("bersayap", "burung, bebek, ayam");
			dicthewan.Add("melata", "ular, cacing");
			
			foreach (KeyValuePair<string, string> KVP in dicthewan) 
			{
				Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
			}
			
			ArrayList arrayhewan = new ArrayList();
			arrayhewan.Add("punya kaki");
			arrayhewan.Add("tidak punya kaki");
			arrayhewan.Add("punya telinga");
			arrayhewan.Add("tidak punya telinga");
			arrayhewan.Add("punya sayap");
			arrayhewan.Add("tidak punya sayap");
			
			foreach(var element in arrayhewan) 
			{
				Console.WriteLine(element);
			}
			arrayhewan.Sort();
			arrayhewan.Insert(7, "punya tanduk");
			foreach(var element1 in arrayhewan) 
			{
				Console.WriteLine(element);
			}
			
			ArrayList arrayhewanclone = (ArrayList)arrayhewan.Clone();
			ArrayList arrayhewanclone2 = arrayhewanclone;
			
			string newarrayhewan = new string[arrayhewanclone.Count];
			arrayhewanclone.CopyTo(newarrayhewan);
			foreach(var element2 in newarrayhewan) 
			{
				Console.WriteLine(element2);
			}
			
		}
	}

class Hewan
{
	string[] hewandarat = { "kambing", "domba", "anjing" };
	string[] hewanberkakiempat = { "kambing", "domba", "anjing" };
	string Name { get; set;}
	
	public Hewan(string name) 
	{
		Name = name;
	}
}
}


//string[] myArray = { "kambing", "anjing", "domba" };
//foreach (int val in myArray)
//    Cons.Write
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
	public class Primer
	{
		//int takav i takav...
		public int Broj;

		public string Tekst;

		//Prvo opisemo kakav tip delegata zelimo
		public delegate int Delegat(int zklj);

		//Zatim mozemo da skladistimo takve delegate
		public Delegat OvoJeGdeIdeMetoda;
		public Delegat OvoJeGdeIdeMetoda2;


		public int Metoda(int x) => x *= 2;

		public Primer()
		{
			Broj = 5;
			Tekst = "asd";
			OvoJeGdeIdeMetoda = Metoda;
		}
	}
}

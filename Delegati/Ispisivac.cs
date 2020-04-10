using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegati
{
	class Ispisivac
	{
		public static string IspisUFajl(string s)
		{
			s = s.ToUpper();
			File.WriteAllText("fajl.txt", s);
			return s;
		}

		public static string SamoFormatiraj(string s)
		{
			s = s.ToUpper();
			return s;
		}

		public delegate string NacinRada(string nesto);
		public NacinRada Ispisi;
		public NacinRada Ispisi2;


		public Ispisivac(NacinRada n)
		{
			Ispisi = n;
		}
	}
}

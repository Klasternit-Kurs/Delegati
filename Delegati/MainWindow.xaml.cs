using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Delegati
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Alaram a = new Alaram();
		Civil c1;
		Civil c2;
		Vatrogasac v1;

		public MainWindow()
		{
			c1 = new Civil(a);
			c2 = new Civil(a);
			v1 = new Vatrogasac(a);

			Resources.Add("civil1", c1);
			Resources.Add("civil2", c2);
			Resources.Add("vatro1", v1);
			InitializeComponent();



			Primer p = new Primer();
			

			//MessageBox.Show(p.Metoda(5).ToString());
			//MessageBox.Show(p.OvoJeGdeIdeMetoda(5).ToString());

			Ispisivac i1 = new Ispisivac(Ispisivac.IspisUFajl);

			i1.Ispisi += Ispisivac.SamoFormatiraj;
			i1.Ispisi += MojaMetoda;


			Ispisivac i2 = new Ispisivac(Ispisivac.SamoFormatiraj);
			Ispisivac i3 = new Ispisivac(MojaMetoda);

			List<Ispisivac> lst = new List<Ispisivac>();
			lst.Add(i1);
			lst.Add(i2);
			lst.Add(i3);


			//i1.Ispisi2?.Invoke("Bla");

			//foreach (Ispisivac i in lst)
			//{
			//	MessageBox.Show(i.Ispisi?.Invoke("test"));
			//}
		}

		private string MojaMetoda(string s) => "Bas me briga za ulazni parametar :)";

		private void Zvrrr(object sender, RoutedEventArgs e)
		{
			a.OglasiSe();
		}
	}
}

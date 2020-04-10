using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
	class Vatrogasac : INotifyPropertyChanged
	{
		public Vatrogasac(Alaram a)
		{
			a.AktivanAlarm += CujemAlarm;
		}

		private string status = "Kuliram";
		public string Status
		{
			get => status;

			set
			{
				status = value;
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Status"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void CujemAlarm()
		{
			Status = "Idem ka pozaru";
		}
	}
}

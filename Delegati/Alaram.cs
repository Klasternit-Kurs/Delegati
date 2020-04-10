using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
	class Alaram
	{
		public delegate void DesioSePozar();

		public event DesioSePozar AktivanAlarm;

		public void OglasiSe()
		{
			AktivanAlarm?.Invoke();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol4NakupniSeznam
{
	public class Polozka
	{
		public string PopisPolozky { get; set; }
		public Polozka(string popisPolozky)
		{
			PopisPolozky = popisPolozky;
		}
		public override string ToString()
		{
			return PopisPolozky;
		}
		public Polozka() 
		{ 
		}
	}
}

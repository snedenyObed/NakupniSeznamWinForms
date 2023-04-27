using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Ukol4NakupniSeznam
{
	public class SpravcePolozek
	{
		public BindingList<Polozka> Polozky { get; set; }
		public SpravcePolozek()
		{
			Polozky = new BindingList<Polozka>();
		}
		public void PridejPolozku (string popis)
		{
			Polozka polozka = new Polozka(popis);
			Polozky.Add(polozka);
		}
		public void OdeberPolozku (Polozka polozka)
		{
			Polozky.Remove(polozka);
		}
		private string cesta = "polozky.xml";
		public void Uloz()
		{
			XmlSerializer serializer = new XmlSerializer(Polozky.GetType());
			using (StreamWriter sw = new StreamWriter(cesta))
			{
				serializer.Serialize(sw, Polozky);
			}
		}
		public void Nacti()
		{
			XmlSerializer serializer = new XmlSerializer(Polozky.GetType());
			if (File.Exists(cesta))
			{
				using (StreamReader sr = new StreamReader(cesta))
				{
					Polozky = (BindingList<Polozka>)serializer.Deserialize(sr);
				}
			}
			else
				Polozky = new BindingList<Polozka>();
		}
	}
}

using System;
using System.Xml;
using System.Collections.Generic;

namespace zaladunek3
{
	public class Products
	{
		List<Product> list;

		public Products()
		{
			list = new List<Product> ();
			using (XmlReader reader = XmlReader.Create("produkty.xml")) {
				while (reader.Read()) {
					if (reader.IsStartElement ()) {
						if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "produkt")) {
                            list.Add(new Product(reader.GetAttribute("name"), Int32.Parse(reader.GetAttribute("size")), Int32.Parse(reader.GetAttribute("value"))));
                        }
					}
				}
			}
		}

		public List<Product> getList() {
			return list;
		}
	}
}


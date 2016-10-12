using System;
using System.Xml;
using System.Collections.Generic;

namespace zaladunek3
{
	public class Bins
	{
		List<Bin> list;

		public Bins()
		{
			list = new List<Bin> ();
			using (XmlReader reader = XmlReader.Create("kontenery.xml")) {
				while (reader.Read()) {
					if (reader.IsStartElement ()) {
						if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "kontener")) {
							list.Add(new Bin(reader.GetAttribute("type"), Int32.Parse(reader.GetAttribute("size"))));
						}
					}
				}
			}
		}

		public List<Bin> getList() {
			return list;
		}
	}
}


using System;

namespace zaladunek3
{
	public class Bin
	{
		private string type;
		private int size;

		public Bin(string name, int size)
		{
			this.type = name;
			this.size = size;
		}

		public string getType() {
			return type;
		}

		public int getSize() {
			return size;
		}
	}
}


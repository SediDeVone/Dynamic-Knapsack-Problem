using System;

namespace zaladunek3
{
	public class Product
	{
		private string name;
		private int size;
        private int value;

		public Product(string name, int size)
		{
			this.name = name;
			this.size = size;
            this.value = 0;
		}
        public Product(string name, int size, int value)
        {
            this.name = name;
            this.size = size;
            this.value = value;
        }

        public string getName() {
			return name;
		}

		public int getSize() {
			return size;
		}

        public int getValue()
        {
            return value;
        }
	}
}


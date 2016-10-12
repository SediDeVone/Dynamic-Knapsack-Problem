using System;
using System.Collections.Generic;

namespace zaladunek3
{
	public class BinPacking
	{
		private List<int> a;
		private int binSize;
		private int binCount;

		public BinPacking(List<int> a, int size)
		{
			this.a = a;
			this.binSize = size;
			this.binCount = this._getBinCount();
		}

		public int getN()
		{
			return a.Count;
		}

		public int getBinCount() {
			return binCount;
		}

		protected int _getBinCount()
		{
			Boolean added = false;
			List<int> bins = new List<int>();

			foreach (int x in a) {
				for (int i=0; i<bins.Count; i++) {
					if (bins[i] - x >= 0) {
						bins[i] -= x;
						added = true;
						continue;
					}
				}
				if (added == false) {
					bins.Add(binSize - x);
				}
				added = false;
            }
            return bins.Count;
		}

		protected int _getFirstFit()
		{
			int binCount = 1;
			int s = binSize;

			for (int i = 0; i < a.Count; i++) {
				if (s - a[i] >= 0) {
					s -= a[i];
					continue;
				}
				else {
					binCount++;
					s = binSize;
					i--;
				}
            }
            return binCount;
		}
	}
}


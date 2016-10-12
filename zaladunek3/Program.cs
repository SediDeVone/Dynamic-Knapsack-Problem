using System;
using System.Windows.Forms;

namespace zaladunek3
{
	class Program
	{
        /*public static void Main (string[] args)
		{
			// Pobieranie listy z dostępnymi produktami
			Products products = new Products ();
			foreach (Product p in products.getList()) {
				System.Console.WriteLine(p.getName() + " " + p.getSize());
            }

			// Pobieranie listy z rodzajami kontenerów
			Bins bins = new Bins ();
			foreach (Bin b in bins.getList()) {
				System.Console.WriteLine(b.getType() + " " + b.getSize());
			}

			List<int> a = new List<int>();
			// Lista z rozmiarami produktów do zapoakowania.
			// Jeśli jakiś produkt chcemy zapakować 3 razy, trzeba dodać go 3 razy do listy.
			a.Add(11);
			a.Add(2);
			a.Add(15);
			a.Add(5);
			a.Add(6);
			a.Add(17);
			a.Add(7);

			BinPacking bp = new BinPacking(a, 20);
            
			System.Console.WriteLine("Liczba do zapakowania produktów: " + bp.getN());
            System.Console.WriteLine("Liczba kontenerów: " + bp.getBinCount());
        }*/

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

    }
}

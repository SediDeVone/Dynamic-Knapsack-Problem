using System;
using System.Collections.Generic;

namespace zaladunek3
{
    class Knapsack
    {
        public bool[] simulate(List<Product> list_of_products, int size_of_knapsack)
        {
            int number_of_products = list_of_products.Count;

            int[] profit = getValues(list_of_products);
            int[] weight = getSizes(list_of_products);
            String[] name = getNames(list_of_products);

            int[,] opt = new int[number_of_products + 1, size_of_knapsack + 1];
            bool[,] sol = new bool[number_of_products + 1, size_of_knapsack + 1];

            for (int n = 1; n <= number_of_products; n++)
            {
                for (int w = 1; w <= size_of_knapsack; w++)
                {
                    int option1 = opt[n - 1, w];
                    int option2 = Int16.MinValue;
                    if (weight[n] <= w) option2 = profit[n] + opt[n - 1, w - weight[n]];
                    opt[n, w] = Math.Max(option1, option2);
                    sol[n, w] = (option2 > option1);
                }
            }

            bool[] take = new bool[number_of_products + 1];
            for (int n = number_of_products, w = size_of_knapsack; n > 0; n--)
            {
                if (sol[n, w]) { take[n] = true; w = w - weight[n]; }
                else { take[n] = false; }
            }
            
            /* String result = "item" + " " + "profit" + " " + "weight" + " " + "take";
            for (int n = 1; n <= number_of_products; n++)
            {
                result += "\n" + name[n] + " " + profit[n] + " " + weight[n] + " " + take[n];
            }*/
            return take;
        }

        public String[] getNames(List<Product> products)
        {
            String[] names = new String[products.Count + 1];
            for (int n = 1; n <= products.Count; n++)
            {
                names[n] = products[n - 1].getName();
            }
            return names;
        }

        public int[] getValues(List<Product> products)
        {
            int[] values = new int[products.Count + 1];
            for (int n = 1; n <= products.Count; n++)
            {
                values[n] = products[n - 1].getValue();
            }
            return values;
        }

        public int[] getSizes(List<Product> products)
        {
            int[] sizes = new int[products.Count + 1];
            for (int n = 1; n <= products.Count; n++)
            {
                sizes[n] = products[n - 1].getSize();
            }
            return sizes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chocolates
{
    class Program
    {

        static public void Main()
        {

            int a = 10;
            int l = 5;
            int[] ar = { 8, 7, 6, 3, 9 };
            int start = 0, end = l - 1;

            while (ar[start] != ar[end])
            {
                if (ar[start] > ar[end])
                {
                    start++;
                }
                else if (ar[start] < ar[end])
                {
                    end--;
                }

            }



            Console.WriteLine("{0}", ar[start]);
            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        int[] furji = new int[50];

        int n, i, j, val, flag;

        void input()
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah element pada Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 50 elemnts \n");
            }
            Console.WriteLine("\n********************");
            Console.WriteLine("Masukkan Element Array");
            Console.WriteLine("\n********************");

            for (int i = 0; i < n; i++) ;
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s = Console.ReadLine();
                furji[i] = Int32.Parse(s);
            }
        }
        public void InsertionSort()
        {
            for (i = 1; i < n; i++)
            {
                val = furji[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < furji[j])
                    {
                        furji[j + 1] = furji[j];
                        j--;
                        furji[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }
        static void Main(string[] args)
        {
         
        }
    }
}

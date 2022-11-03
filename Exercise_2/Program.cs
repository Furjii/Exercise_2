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
        }
        static void Main(string[] args)
        {
         
        }
    }
}

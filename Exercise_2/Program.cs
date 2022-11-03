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
                Console.WriteLine("Enter the number of element in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
                    break;
            }
        }
        static void Main(string[] args)
        {
         
        }
    }
}

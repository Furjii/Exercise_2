using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contohaja
{
    internal class Program
    {
        int[] furji = new int[50];

        //Number of elements in array
        int n, i, fi, val, flag;
        void input()
        {
            while (true)
            {
                Console.Write("Masukkan Jumlah Elemen Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 50 elements \n");
            }
            Console.WriteLine("\n********************");
            Console.WriteLine("Masukkan Element Array");
            Console.WriteLine("\n********************");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                furji[i] = Int32.Parse(s1);
            }
        }
        public void InsertionSort()
        {
            for (i = 1; i < n; i++)
            {
                val = furji[i];
                flag = 0;
                for (fi = i - 1; fi >= 0 && flag != 1;)
                {
                    if (val < furji[fi])
                    {
                        furji[fi + 1] = furji[fi];
                        fi--;
                        furji[fi + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }
        public void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        void display()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("-------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(furji[fi]);
            }

        }


        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=================");
                    Console.WriteLine("1. insertion seacrh");
                    Console.WriteLine("2. binary seacrh");
                    Console.WriteLine("3. exit");
                    Console.WriteLine("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("...................");
                            Console.WriteLine("insertion Search ");
                            Console.WriteLine("...................");
                            myList.input();
                            myList.InsertionSort();
                            break;
                        
                    }
                    Console.WriteLine("\nPilih menu lagi? (y/n): ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                //to exit from the console
                Console.WriteLine("\n\nPress return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);

        }
    }
}
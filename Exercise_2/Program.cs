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

        int n, i, j, val, flag, middle;

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

        public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            if (left < right)
            {
                int fi = left + (right - left) / 2;
                mergesort(furji, left, mid);
                mergesort(furji, mid + 1, right);
                merge(furji, left, mid, right);
            }
        }

        // merge function performs sort and merge operations
        // for mergesort function
        static void merge(int[] Array, int left, int mid, int right)
        {
            // Create two temporary array to hold split 
            // elements of main array 
            int n1 = mid - left + 1; //no of elements in LeftArray
            int n2 = right - mid;     //no of elements in RightArray    
            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                LeftArray[i] = Array[left + i];
            }

            for (int i = 0; i < n2; i++)
            {
                RightArray[i] = Array[mid + i + 1];
            }

            // In below section x, y and z represents index number
            // of LeftArray, RightArray and Array respectively
            int x = 0, y = 0, z = left;
            while (x < n1 && y < n2)
            {
                if (LeftArray[x] < RightArray[y])
                {
                    Array[z] = LeftArray[x];
                    x++;
                }
                else
                {
                    Array[z] = RightArray[y];
                    y++;
                }
                z++;
            }

            // Copying the remaining elements of LeftArray
            while (x < n1)
            {
                Array[z] = LeftArray[x];
                x++;
                z++;
            }

            // Copying the remaining elements of RightArray
            while (y < n2)
            {
                Array[z] = RightArray[y];
                y++;
                z++;
            }
        }

        // function to print array
        static void PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");
        }

        // test the code
        static void Main(string[] args)
        {
            int[] MyArray = { 10, 1, 23, 50, 4, 9, -4 };
            int n = MyArray.Length;
            Console.Write("Original Array\n");
            PrintArray(MyArray);

            mergesort(MyArray, 0, n - 1);
            Console.Write("\nSorted Array\n");
            PrintArray(MyArray);
        }

        private static void mergesort(int[] myArray, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        static void fi(string[] args)
        {
         
        }
    }
}

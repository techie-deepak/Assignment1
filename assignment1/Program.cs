using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }


        public static int avg(int[] arr)
        {
            int sum1 = sum(arr);
            return sum1 / arr.Length;
        }

        public static int largest(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void EvenOdd(int[] arr)
        {
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    odd += 1;
                }
            }
            Console.Write("Total Even number of elements: ");
            Console.WriteLine(even);

            Console.Write("Total odd numver of Elements: ");
            Console.WriteLine(odd);
        }

        public static void reverseArray(int[] arr)
        {
            int mid = arr.Length / 2;
            int end = arr.Length - 1;
            for (int i = 0; i < mid; i++)
            {
                int temp = arr[i];
                arr[i] = arr[end];
                arr[end] = temp;
                end--;

            }

            Console.Write("Reversed array: ");
            foreach (int ele in arr)
            {
                Console.Write(ele + "-->");
            }
        }

        public static void multiplay_Factor(int[] arr)
        {
            Console.Write("Enter a number to be multiplied: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * num;
            }
            Console.Write("Multiplied array: ");
            foreach (int ele in arr)
            {
                Console.Write(ele + "-->");
            }
        }

        public static int searchIndex(int[] arr)
        {
            Console.WriteLine("Enter the values to be found: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            foreach (int ele in arr)
            {
                if (ele == value)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static int secondSmallest(int[] arr)
        {
            Array.Sort(arr);
            int secondSmallest = arr[0];
            foreach (int ele in arr)
            {
                if (ele != secondSmallest)
                {
                    secondSmallest = ele;
                    return secondSmallest;
                }
            }
            return -1;
        }

        public static void removeDuplicate(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int ele in arr)
            {
                set.Add(ele);
            }
            foreach (int ele in set)
            {
                Console.Write(ele + " ");
            }
;
        }
        public static void common_ele(int[] arr1, int[] arr2)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        set.Add(arr1[i]);
                    }
                }
            }
            foreach (int ele in set)
            {
                Console.Write(ele + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 1, 2 };
            int[] arr2 = { 5, 6, 4, 1, 2, 8, 9 };
            /* Console.Write("Sum Of the elements of array: ");
             Console.WriteLine(sum(arr));

             Console.Write("Average of the elements of an array: ");
             Console.WriteLine(avg(arr));

             Console.Write("Largest Element in the array is: ");
             Console.WriteLine(largest(arr));

             EvenOdd(arr);

             reverseArray(arr);

             Console.WriteLine();
             multiplay_Factor(arr);
             Console.ReadLine();

             Console.Write("IndexValue: ");
             Console.WriteLine(searchIndex(arr)); 

            Console.WriteLine("Second Smallest Value is: ");
            Console.WriteLine(secondSmallest(arr));

            removeDuplicate(arr);

            common_ele(arr1, arr2);



            

            Console.ReadLine();
        }
    }
}
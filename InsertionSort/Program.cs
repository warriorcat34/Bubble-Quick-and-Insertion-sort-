﻿namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");
            int[] arr = new int[] { 2, 4, -5, 1, 10 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swapVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapVar;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstTaskJmm
{
    internal class Insertion
    {
        public Insertion() 
        {
            int[] arr = new int[] { 23, 9, 80, 56, 76, 8, 79, 9, 789, 45, 6, 67, 32, 455, 97, 82, 53, 85, 34, 23, 445, 213, 432, 25, 12, 99, 34, 60, 15, 100, 1, 2, 3 };
            int i, j, val, flag;

            var timer = new Stopwatch();
            Console.Write("\nInitial Array is: ");

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            timer.Start();
            for (i = 1; i < arr.Length; i++)
            {
                
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }

            }
            timer.Stop();
            Console.Write("\n\nInsertion Sorted Array is: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            TimeSpan timeTaken = timer.Elapsed;
            Console.Write($"\nTimes For Insertion Sorted: {timeTaken.TotalMilliseconds} seconds");



        }
       
    }
}

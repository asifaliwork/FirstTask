using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskJmm
{
    internal class Bubble
    {
        public Bubble() 
        {
            int[] arry = new int[] { 23, 9,80 ,56,76,8,79,9,789,45,6,67,32,455,97,82,53,85, 34, 23, 445, 213, 432, 25, 12, 99, 34, 60, 15, 100, 1,2,3 };     
            //int count = 0;
            var timerr = new Stopwatch();
            Console.Write("\nInitial Array is: ");
            foreach (int item in arry)
            {
                Console.Write(item + " ");
            }
            timerr.Start();
            for (int i = 0; i <= arry.Length - 1; i++)
            {                
                for (int x = 0; x <= arry.Length - 2; x++)
                {
                  //  count = count + 1;

                    if (arry[x] > arry[x + 1])
                    {
                        var a = arry[x];
                        arry[x] = arry[x + 1];
                        arry[x + 1] = a;
                    }
                }
            }
            timerr.Stop();
            Console.Write(" \n\nBubble Sorted Array: ");
            foreach (int x in arry)
            {
                Console.Write(x + " ");
            }
            TimeSpan timeTaken = timerr.Elapsed;
            Console.WriteLine($"\nTimes For Bubble Sorted: {timeTaken.TotalMilliseconds} seconds");
        }
    }
}

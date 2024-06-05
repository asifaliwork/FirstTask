using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskJmm
{
    internal class AsyncBubble
    {
        

        public async Task Asyncbubble() 
        {
            int[] arry = new int[] { 23, 9, 80, 56, 76, 8, 79, 9, 789, 45, 6, 67, 32, 455, 97, 82, 53, 85, 34, 23, 445, 213, 432, 25, 12, 99, 34, 60, 15, 100, 1, 2, 3 };           
            var timrr = new Stopwatch();
            Console.Write("\nSimple Bubble for Async Array is: ");
            foreach (int item in arry)
            {
                Console.Write(item + " ");
            }
           
            await Task.Run( () =>
            {
                timrr.Start();
                for (int i = 0; i <= arry.Length - 1; i++)
                {
                    for (int x = 0; x <= arry.Length - 2; x++)
                    {
                          

                        if (arry[x] > arry[x + 1])
                        {
                            var a = arry[x];
                            arry[x] = arry[x + 1];
                            arry[x + 1] = a;
                        }
                    }
                }
                timrr.Stop();
            });
           

            Console.Write(" \n\nAsync Bubble Sorted Array: ");
            foreach (int x in arry)
            {
                Console.Write(x + " ");
            }
            TimeSpan timeTaken = timrr.Elapsed;
            Console.WriteLine($"\nTimes for Async Bubble {timeTaken.TotalMilliseconds} seconds");


        }
    }
}

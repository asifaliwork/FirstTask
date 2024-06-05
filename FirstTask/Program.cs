using FirstTaskJmm;
using System.Diagnostics;

namespace synchronize
{
    class Program
    {
        static void Main(string[] args)
        {

            Bubble bubble = new Bubble();
            AsyncBubble asyncBubble = new AsyncBubble();
            asyncBubble.Asyncbubble().GetAwaiter().GetResult();

            Insertion insertion = new Insertion();

            AsyncInsertion asyncInsertion = new AsyncInsertion();
            asyncInsertion.Asyncinsertion().GetAwaiter().GetResult();
        }
    }



}
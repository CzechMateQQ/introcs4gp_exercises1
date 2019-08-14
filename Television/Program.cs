using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Television Project");
            Television myTV = new Television();
            //Examples of variable & string work.
            Console.WriteLine($"The current channel is {myTV.channel()}");
            //Console.WriteLine("The current channel is " + myTV.channel() );
            //Console.WriteLine("The current channel is {0}", myTV.channel());
            myTV.increaseChannel();
            Console.WriteLine($"The current channel is {myTV.channel()}");
            myTV.increaseChannel();
            myTV.increaseChannel();
            myTV.increaseChannel();
            Console.WriteLine($"The current channel is {myTV.channel()}");


            Console.ReadKey();
        }
    }
}

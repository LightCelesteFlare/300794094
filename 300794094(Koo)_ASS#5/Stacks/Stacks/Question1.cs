using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Question1
    {
        /* Write a program that inputs a line of text and uses a stack object
           to display the line reversed
        */
        public static void Main() {
            string text = "First one in, Second one in, Third one in, Fourth one in";
            Console.WriteLine("Raw Text is shown");
            Console.Write(text);

            Console.WriteLine("\n\n---Separating the text---");
            Stack myStacks = new Stack();
            for(int i = 0; i < 4; i++)
            {
                string[] partline = text.Split(',');
                myStacks.Push(partline[i]);
            }

            //myStacks.Push("First one in");
            //myStacks.Push("Second one in");
            //myStacks.Push("Third one in");
            //myStacks.Push("Fourth one in");

            // Display the Stacks
            Console.Write("Stack Values:");
            PrintValues( myStacks, '\t');
            Console.WriteLine("Hit any key to continue");
            Console.ReadKey();

            Console.WriteLine("\nStack Values to Array");
            Console.Write("Stack Values:");
            PrintValues(myStacks, '\t');

            Console.WriteLine("\n--then reverse it--");
            Console.Write("Stack Values:");
            PrintValues(myStacks.ToArray().Reverse());

            Console.ReadKey();


        }

        public static void PrintValues(IEnumerable myCollection, char mySeparator)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}{1} ", mySeparator, obj);
            Console.WriteLine();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}

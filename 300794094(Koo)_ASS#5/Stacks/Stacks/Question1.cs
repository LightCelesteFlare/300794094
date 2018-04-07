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
            
            Stack myStacks = new Stack();
            myStacks.Push("First one in");
            myStacks.Push("Second one in");
            myStacks.Push("Third one in");
            myStacks.Push("Fourth one in");

            // Display the Stacks
            Console.Write("Stack Values:");
            PrintValues( myStacks, '\t');
            Console.ReadKey();


        }

        public static void PrintValues(IEnumerable myCollection, char mySeparator)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0}{1} |", mySeparator, obj);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW1
{
    public static class DataPrinter
    {
        public static void PrintCollection<T>(
            string messageToDisplay,
            MyCollection<T> collection)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(messageToDisplay);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write(collection[i] + " ");
            }
        }
    }
}

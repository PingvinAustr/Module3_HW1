using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW1
{
    public static class Starter
    {
        public static void Run()
        {
            // =========== INT COLLECTION ==================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Example of INT collection\n");
            Console.ForegroundColor = ConsoleColor.White;

            MyCollection<int> list = new MyCollection<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            DataPrinter.PrintCollection(
                "Collection after 3 items were added using Add():",
                list);

            List<int> listToAddRange = new List<int> { 4, 5, 6 };
            list.AddRange(listToAddRange);
            DataPrinter.PrintCollection(
                "\n\nCollection after 3 List items " +
                "were added using AddRange()",
                list);

            int[] arr = new int[4] { 7, 8, 9, 5 };
            list.AddRange(arr);
            DataPrinter.PrintCollection(
                "\n\nCollection after 3 Array " +
                "items were added using AddRange()",
                list);

            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            DataPrinter.PrintCollection(
                "\n\nCollection after removing 3 items using RemoveAt(0)",
                list);

            list.Remove(5);
            DataPrinter.PrintCollection(
                "\n\nCollection after removing '5' item using Remove(5)",
                list);

            list.Sort();
            DataPrinter.PrintCollection(
                "\n\nCollection after sorting:",
                list);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nGoing through collection using foreach");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            // =========== STRING COLLECTION ==================
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nExample of STRING collection\n");
            Console.ForegroundColor = ConsoleColor.White;

            MyCollection<string> listString = new MyCollection<string>();
            listString.Add("aa");
            listString.Add("bb");
            listString.Add("cc");
            DataPrinter.PrintCollection(
                "Collection after 3 items were added using Add():",
                listString);

            List<string> listStringToAddRange =
                new List<string> { "dd", "ee", "ff" };
            listString.AddRange(listStringToAddRange);
            DataPrinter.PrintCollection(
                "\n\nCollection after 3 List items" +
                " were added using AddRange()",
                listString);

            string[] arrToAddString = new string[4] { "gg", "hh", "ii", "ee" };
            listString.AddRange(arrToAddString);
            DataPrinter.PrintCollection(
                "\n\nCollection after 3 Array items " +
                "were added using AddRange()",
                listString);

            listString.RemoveAt(0);
            listString.RemoveAt(0);
            listString.RemoveAt(0);
            DataPrinter.PrintCollection(
                "\n\nCollection after removing 3 items using RemoveAt(0)",
                listString);

            listString.Remove("ee");
            DataPrinter.PrintCollection(
                "\n\nCollection after removing 'ee' item using Remove('ee')",
                listString);

            listString.Sort();
            DataPrinter.PrintCollection(
                "\n\nCollection after sorting:",
                listString);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nGoing through collection using foreach");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in listString)
            {
                Console.Write(item + " ");
            }
        }
    }
}

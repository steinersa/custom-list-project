using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> combined = new CustomList<int>();
            //CustomList<int> items = new CustomList<int>();

            //items.Add(4);
            //items.Add(2);
            //items.Add(3);
            //items.Add(4);
            //items.Add(5);
            //items.Add(6);
            //items.Remove(7);

            //List<string> one = new List<string> { "test", "hello", "sarah" };
            //List<string> two = new List<string> { "1", "2", "3" };

            CustomList<int> testOne = new CustomList<int>();
            testOne.Add(1);
            testOne.Add(2);
            testOne.Add(3);

            CustomList<int> testTwo = new CustomList<int>();
            testTwo.Add(4);
            testTwo.Add(5);
            testTwo.Add(6);

            testOne.OverloadPlus(testOne, testTwo);

            //foreach (int thing in items)
            //{
            //    Console.WriteLine(thing);
            //}

            //Console.WriteLine(items[1]);
            //Console.ReadLine();

        }

    }
}

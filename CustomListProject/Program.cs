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

            CustomList<int> items = new CustomList<int>();

            items.Add(4);
            items.Add(2);
            items.Add(3);
            items.Add(4);
            items.Add(5);
            items.Add(6);
            items.Remove(4);
            items.ToString();

            //Console.WriteLine(items[1]);
            //Console.ReadLine();

        }

    }
}

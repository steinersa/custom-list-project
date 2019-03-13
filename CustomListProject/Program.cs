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

            items.Add(1);
            items.Add(2);

            for (int i = 0; i < items[4]; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

        }
    }
}

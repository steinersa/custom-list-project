using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        // member variables
        private T[] items;
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; } // if index is within array length
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        // constructor
        public CustomList()
        {
            items = new T[4];
            count = 0;
        }

        // member methods
        public void Add(T itemToAdd)
        {
            //if(Counter >= items)
            //{
                // create new array
                // public T[] items = new T[i += 4];
            //}
            // else
            //{
            items[Count] = itemToAdd;
            count++;
            //}
        }
        
    }
}

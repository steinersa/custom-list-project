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
            set
            {
                if (i > count)
                {
                    items[i] = value;
                }
                else
                {
                    throw new System.ArgumentException("Index out-of-bounds.");
                }
            }
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int capacity;

        // constructor
        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        // member methods
        public void Add(T itemToAdd)
        {
            if(count >= capacity)
            {
                T[] moreItems = new T[capacity += 4];
                foreach (T thing in items)
                {
                    //put into moreItems at index where it currently is
                    //items[i] = moreItems[i];
                    
                }



                //items[capacity += 4];
                //foreach
                // public T[] items = new T[i += 4];
            }
            else
            {
            items[count] = itemToAdd;
            count++;
            }
        }
        
    }
}

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
                if (i >= count)
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
        public void ExpandArray()
        {
            T[] newItems = new T[capacity += 4];
            for(int i = 0; i < count; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }

        public void Add(T itemToAdd)
        {
            if(count >= capacity)
            {
                ExpandArray();
                Add(itemToAdd);
            }
            else
            {
            items[count] = itemToAdd;
            count++;
            }
        }
        
    }
}

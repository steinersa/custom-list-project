using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        // member variables
        private T[] items;
        public T this[int i]
        {
            get
            {
                if (i >= count)
                {
                    throw new System.ArgumentException("Index out-of-bounds");
                }
                else
                {
                    return items[i];
                }
                
            }
            set
            {
                if (i >= count)
                {
                    throw new System.ArgumentException("Index out-of-bounds");
                }
                else
                {
                    items[i] = value;
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
        public bool isRemoved;

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

        public void Remove(T itemToRemove)
        {
            isRemoved = false;
            int countNew = 0;
            T[] newItems = new T[capacity];
            for (int i = 0, j = 0; i < count; i++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    continue;
                }
                else
                {
                    newItems[j] = items[i];
                    j++;
                    countNew++;
                }
                if (i != j)
                {
                    isRemoved = true;
                }
            }
            count = countNew;
            items = newItems;
        }

        public override string ToString()
        {
            string inString = "";
            for (int i = 0; i < count; i++)
            {
                inString += items[i];
            }
            return inString;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
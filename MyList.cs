using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class MyList<T>
    {
        private int _count;
        public int Count { get => _count; }

        public int Capasity = 0;
        public T[] array;
        public MyList()
        {
            array = new T[0];
        }
        public MyList(int capasity)
        {
            if (capasity>0)
            {
                Capasity = capasity;
            }
        }
        public void AddItem(T item)
        {
            Resizable(array.Length == _count);
            array[Count] = item;
            _count++;
        }
        public void AddItems(params T[] items)
        {
            foreach (var item in array)
            {
                AddItem(item);
            }
        }
        public void Resizable(bool value)
        {
            if (value)
            {
                if (array.Length>0)
                {
                    Array.Resize(ref array, array.Length * 2);
                }
                else
                {
                    Array.Resize(ref array, array.Length + 2);
                }
            }
        }
        public void ShowList()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

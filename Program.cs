using System;

namespace ConsoleApp10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(4);
            list.AddItems(4,6,7);
            list.ShowList();
        }
       
    }
}
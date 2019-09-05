using System;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListDemo linkedList = new LinkedListDemo();
            ////linkedList.Print();
            //int k = Convert.ToInt32(Console.ReadLine());
            //linkedList.FindKthToLastElement(k);

            LinkedListIntDemo listIntDemo = new LinkedListIntDemo();
            int k = Convert.ToInt32(Console.ReadLine());
            listIntDemo.Partition(k);

            Console.WriteLine("Console Complete !!");
        }
    }
}

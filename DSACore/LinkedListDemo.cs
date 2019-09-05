
using System;
using System.Collections.Generic;
using System.Text;

namespace DSACore
{
    public class LinkedListDemo:ILinkList
    {
        LinkedList<String> my_list = new LinkedList<String>();
        public LinkedListDemo()
        {
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");

        }


        public void Print()
        {
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
        }

        public void PrintNode(LinkedListNode<string> listNode)
        {
            Console.WriteLine(listNode.Value);
        }

        public int FindKthToLastElement(int K)
        {
            LinkedListNode<string> listNode1 = my_list.First;
            LinkedListNode<string> listNode2 = my_list.First;
            
            for(int i = 0; i<K; i++)
            {
                if (listNode2.Next == null)
                {
                    Console.WriteLine("K is greater than Linked List Size");
                    return 0;
                }
                listNode1 = listNode1.Next;
            }

            while (listNode1 != null)
            {
                listNode1 = listNode1.Next;
                listNode2 = listNode2.Next;
            }

            PrintNode(listNode2);
            return 1;
        }

        public void DeleteNode(LinkedListNode<string> listNode)
        {

        }

    }

    public class LinkedListIntDemo:ILinkListInt
    {
        LinkedList<int> my_list = new LinkedList<int>();
        public LinkedListIntDemo()
        {
            my_list.AddLast(24);
            my_list.AddLast(38);
            my_list.AddLast(12);
            my_list.AddLast(1);
            my_list.AddLast(54);

        }

        public void Print(LinkedList<int> list)
        {
            foreach (int num in list)
            {
                Console.WriteLine(num+"->");
            }
        }

        

        public void PrintNode(LinkedListNode<int> listNode)
        {
            Console.WriteLine(listNode.Value);
        }

       public void Partition (int x)
        {
            LinkedList<int> beforePartition = new LinkedList<int>();
            LinkedList<int> afterPartition = new LinkedList<int>();

            LinkedListNode<int> node = my_list.First;

            while (node != null)
            {
                if (node.Value < x)
                {
                    beforePartition.AddFirst(node.Value);
                    
                }
                else
                {
                    afterPartition.AddFirst(node.Value);
                }
                node = node.Next;
            }
            Console.WriteLine("Left Partition");
            Print(beforePartition);
            Console.WriteLine("Right Partition");
            Print(afterPartition);
        }

    }
}

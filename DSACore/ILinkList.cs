using System;
using System.Collections.Generic;
using System.Text;

namespace DSACore
{
    public interface ILinkList
    {
        void Print();
        void PrintNode(LinkedListNode<string> listNode);
        int FindKthToLastElement(int K);
        void DeleteNode(LinkedListNode<string> listNode);
    }

    public interface ILinkListInt
    {
        void Print(LinkedList<int> list);
        void PrintNode(LinkedListNode<int> listNode);
    }
}

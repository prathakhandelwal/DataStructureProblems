using System;
using System.Collections.Generic;
using System.Text;

namespace TreeProblems
{
    public class Node
    {
        Node leftNode;
        Node rightNode;
        int data;

        public Node(int data)
        {
            this.data = data;
        }

        public void Insert(int value)
        {
            if (value <= data)
            {
                if (leftNode == null)
                {
                    leftNode = new Node(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
            else
            {
                if (rightNode == null)
                {
                    rightNode = new Node(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
        }


        public bool Contains(int value)
        {
            if (data == value)
            {
                return true;
            }
            else if (data >= value)
            {
                if (leftNode == null)
                {
                    return false;
                }
                else
                {
                    leftNode.Contains(value);
                }
            }
            else
            {
                if (rightNode == null)
                {
                    return false;
                }
                else
                {
                    rightNode.Contains(value);
                }
            }
            return false;
        }

        public void PrintInOrder()
        {
            if (leftNode != null)
            {
                leftNode.PrintInOrder();
            }
            Console.WriteLine(data);
            if (rightNode != null)
            {
                leftNode.PrintInOrder();
            }
        }

        public void PrintPreOrder()
        {
            Console.WriteLine(data);
            if (leftNode != null)
            {
                leftNode.PrintPreOrder();
            }           
            if (rightNode != null)
            {
                leftNode.PrintPreOrder();
            }
        }

        public void PrintPostOrder()
        {            
            if (leftNode != null)
            {
                leftNode.PrintPostOrder();
            }
            if (rightNode != null)
            {
                leftNode.PrintPostOrder();
            }
            Console.WriteLine(data);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree
    {
        public static Node Root { get; set; }
        public List<int> List { get; set; }

        public BinaryTree()
        {
            List = new List<int>();
        }
        public void  Add(int value)
        {
            Node node = new Node(value);
            if (Root == null)
                Root = node;
            else 
            {
                var current = Root;
     
                while (true)
                {
                    if (node.Value > current.Value)
                    {
                        if (current.Right == null)
                        {
                            current.Right = node;
                            return;
                        }
                        else
                            current = current.Right;
                        
                    }
                    else if (node.Value < current.Value)
                    {
                        if (current.Left == null)
                        {
                            current.Left =node;
                            return;
                        }
                        else
                            current = current.Left;
                        
                    }
                }

            }
            

        }

        public void Print()
        {

            PrintInOrder(Root);

        }

        private void PrintInOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintInOrder(node.Left);
            Console.WriteLine(node.Value);
            PrintInOrder(node.Right);
            

        }

        public int Factorial(int n)
        {

            if (n == 1)
                return 1;
            else
            return Factorial(n - 1);

        }
    }
}

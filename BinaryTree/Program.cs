using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(20);
            tree.Add(30);
            tree.Add(21);
            tree.Add(5);
            tree.Add(4);
            tree.Add(1);
            tree.Add(29);
            tree.Print();
            Console.WriteLine("Hello World!");
        }
    }
}

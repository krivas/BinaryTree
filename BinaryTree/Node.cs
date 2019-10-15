using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Node Right { get; set; }
        public Node Left { get; set; }
        public int Value { get; set; }

        public Node(int _value)
        {
            this.Value = _value;
        }
    }
}

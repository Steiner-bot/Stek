using System;
using System.Collections.Generic;
using System.Text;

namespace Мое_дерево
{
    public class Node
    {
        public int _data;
        public Node left;
        public Node right;

        public Node(int x)
        {
            _data = x;
            this.left = null;
            this.right = null;
        }
    }
}

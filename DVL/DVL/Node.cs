using System;
using System.Collections.Generic;
using System.Text;

namespace DVL
{
    class Node
    {
        public int _data;
        public Node left;
        public Node right;
        public int height;

        public Node(int x)
        {
            height = 1;
            _data = x;
            this.left = null;
            this.right = null;
        }
    }
}

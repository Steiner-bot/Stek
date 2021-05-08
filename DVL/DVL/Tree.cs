using System;
using System.Collections.Generic;
using System.Text;

namespace DVL
{
    class Tree
    {
        public Node _root;


        private int Heigth(Node p)
        {
            return p == null ? 0 : p.height;
        }

        private int Balance(Node p)
        {
            return p == null ? 0 : Heigth(p.left) - Heigth(p.right);
        }
        public void Insert(int x)
        {
            Insert(_root, x);
        }

        private Node Insert(Node r, int x)
        {
            if (r == null)
                return new Node(x);
            if (x < r._data)
            {
                r.left = Insert(r.left, x);
            }

            if (x > r._data)
            {
                r.right = Insert(r.right, x);
            }

            r.height = 1 + Math.Max(Heigth(r.left), Heigth(r.right));
            int b = Balance(r);
            return r;
        }

        private KeyValuePair<int, string> ToStringHelper(Node n)
        {
            if (n == null)
                return new KeyValuePair<int, string>(1, "\n");

            var left = ToStringHelper(n.left);
            var right = ToStringHelper(n.right);

            var objString = n._data.ToString();
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(' ', left.Key - 1);
            stringBuilder.Append(objString);
            stringBuilder.Append(' ', right.Key - 1);
            stringBuilder.Append('\n');

            var i = 0;
            while (i * left.Key < left.Value.Length && i * right.Key < right.Value.Length)
            {
                stringBuilder.Append(left.Value, i * left.Key, left.Key - 1);
                stringBuilder.Append(' ', objString.Length);
                stringBuilder.Append(right.Value, i * right.Key, right.Key);
                ++i;
            }

            while (i * left.Key < left.Value.Length)
            {
                stringBuilder.Append(left.Value, i * left.Key, left.Key - 1);
                stringBuilder.Append(' ', objString.Length + right.Key - 1);
                stringBuilder.Append('\n');

                ++i;
            }

            while (i * right.Key < right.Value.Length)
            {
                stringBuilder.Append(' ', left.Key + objString.Length - 1);
                stringBuilder.Append(right.Value, i * right.Key, right.Key);
                ++i;
            }
            return new KeyValuePair<int, string>(left.Key + objString.Length + right.Key - 1, stringBuilder.ToString());
        }
        public string Print()
        {
            var res = ToStringHelper(_root).Value;
            return res;
        }
    }
}

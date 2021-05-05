using System;
using System.Collections.Generic;
using System.Text;

namespace Мое_дерево
{
    public class Tree
    {
        public Node _root;

        public Node BrRot(Node r)
        {
            var p = r.left;
            r.left = LRot(p);
            return RRot(r);
        }
        public Node BlRot(Node r)
        {
            var p = r.right;
            r.right = RRot(p);
            return LRot(r);
        }
        public Node RRot(Node r)
        {
            var p = r.left;
            r.left = p.right;
            p.right = r;
            return p;
        }

        public Node LRot(Node r)
        {
            var p = r.right;
            r.right = p.left;
            p.left = r;
            return p;
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
        private void Store(List<Node> n, Node p)
        {
            if (p == null)
                return;
            Store(n, p.left);
            n.Add(p);
            Store(n, p.right);
        }

        private Node build_ideal(List<Node> n, int a, int b)
        {
            if (a > b)
                return null;
            int m = (a + b) / 2;
            var p = n[m];
            p.left = build_ideal(n, a, m - 1);
            p.right = build_ideal(n, m + 1, b);
            return p;
        }

        public void reorder_to_ideal()
        {
            _root = make_Ideal(_root);
        }

        private Node make_Ideal(Node p)
        {
            var nodes = new List<Node>();
            Store(nodes, p);
            return build_ideal(nodes, 0, nodes.Count - 1);
        }

        public void Insert(int x)
        {
            if (_root == null)
            {
                _root = new Node(x);
            }
            else
            {
                Insert(x, _root);
            }
        }

        private void Insert(int x, Node p)
        {
            if (x < p._data)
            {
                if (p.left == null)
                    p.left = new Node(x);
                else
                    Insert(x, p.left);
            }

            if (x > p._data)
            {
                if (p.right == null)
                    p.right = new Node(x);
                else
                    Insert(x, p.right);
            }
        }

        public int Size()
        {
            int count = 0;
            InOrder(_root, ref count);
            return count;
        }

        private void InOrder(Node localRoot, ref int count)
        {
            //Симметричный обход для подсчета кол-ва элементов в дереве
            if (localRoot != null)
            {
                count++;
                InOrder(localRoot.left, ref count);
                InOrder(localRoot.right, ref count);
            }
        }

        public int MinValueItr()
        {
            Node current = _root;
            Node last = null;
            while (current != null)
            {
                last = current; //сохранение узла
                current = current.left;
            }

            return last._data;
        }

        public int MaxValueItr()
        {
            Node current = _root;
            //Node last = null;
            while (current.right != null)
            {
                //last = current; //сохранение узла
                current = current.right;
            }

            return current._data;
        }

        public int MinValueRec()
        {
            if (_root.left == null)
                return -1;
            return MinValueRec(_root);
        }

        private int MinValueRec(Node node)
        {
            if (node.left != null)
            {
                return MinValueRec(node.left);
            }

            return node._data;
        }

        public int MaxValueRec()
        {
            if (_root.right == null)
                return -1;
            return MaxValueRec(_root);
        }

        private int MaxValueRec(Node node)
        {
            if (node.right != null)
            {
                return MaxValueRec(node.right);
            }

            return node._data;
        }

        public bool Contains(int x)
        {
            return Contains(x, _root);
        }

        private bool Contains(int x, Node current)
        {
            if (x == current._data)
                return true;
            if (x < current._data)
            {
                if (current.left != null)
                    Contains(x, current.left);
                else
                {
                    return false;
                }
            }
            else if (current.right != null)
                Contains(x, current.right);
            else
            {
                return false;
            }

            return false;
        }

        public void Clear()
        {
            _root = null;
        }

        public int LeafCount()
        {
            int count = 0;
            LeafCount(_root, ref count);
            return count;
        }

        private void LeafCount(Node current, ref int count)
        {
            if (current.left != null)
                LeafCount(current.left, ref count);
            if (current.right != null)
                LeafCount(current.right, ref count);
            if (current.left == null && current.right == null)
            {
                count++;
            }
        }

        public void Print2()
        {
            Print(_root, 0);
        }

        private void Print(Node p, int h)
        {
            if (p.right != null)
                Print(p.right, h + 1);
            for (int i = 0; i < h; i++)
                Console.Write("-");
            Console.WriteLine(p._data);
            if (p.left != null)
                Print(p.left, h + 1);
        }

        public void CreateList(List<int> list)
        {
            Print2(_root, list);
        }

        private void Print2(Node p, List<int> list)
        {
            if (p.left != null)
                Print2(p.left, list);
            list.Add(p._data);
            if (p.right != null)
                Print2(p.right, list);
        }

        public int GetHeight()
        {
            return GetHeight(_root);
        }

        private int GetHeight(Node p)
        {
            if (p == null)
                return 0;
            return 1 + Math.Max(GetHeight(p.left), GetHeight(p.right));
        }
    }
}

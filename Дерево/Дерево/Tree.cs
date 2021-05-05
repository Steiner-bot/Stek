using System;
using System.Collections.Generic;
using System.Text;

namespace Дерево
{
    public class Tree
    {
        private Node _root;

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
            return MaxValueRec(_root);
        }

        private int MaxValueRec(Node node)
        {
            if (node.right != null)
            {
                return MinValueRec(node.left);
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
                //return;
            }

            //count++;
        }

        public int GetHeight()
        {
            return Height(this.Size());
        }

        public void print()
        {
            print(_root, 0);
        }

        private void print(Node p, int h)
        {
            if (p.right != null)
                print(p.right, h + 1);
            for (int i = 0; i < h; i++)
                Console.Write("-");
            Console.WriteLine(p._data);
            if (p.left != null)
                print(p.left, h + 1);

        }
        private int Height(int N) //формула высоты в двоичном дереве (log 2 (N + 1)) — 1, где N - кол-во узлов в дереве 
                                  
        {
            return (int)Math.Ceiling(Math.Log(N + 1) / Math.Log(2)) - 1;
        }
    }
}

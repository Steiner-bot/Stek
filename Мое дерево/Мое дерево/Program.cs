using System;
using System.Collections.Generic;

namespace Мое_дерево
{
    internal class Program
    {
        private static Tree tree = new Tree();
        private static List<int> list = new List<int>();
        private static Random rnd = new Random(2);
        public static void Main(string[] args)
        {
            //1
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(4);
            Console.WriteLine(tree.Print());
            tree._root = tree.RRot(tree._root);
            Console.WriteLine(tree.Print());
            tree._root = tree.LRot(tree._root);
            Console.WriteLine(tree.Print());
            //AVL:
            //tree.Insert(5);
            //tree.Insert(1);
            //tree.Insert(6);
            //tree.Insert(0);
            //tree.Insert(3);
            //tree.Insert(2);
            //tree.Insert(4);
            //Console.WriteLine(tree.Print());
            //tree._root = tree.BrRot(tree._root);
            //Console.WriteLine(tree.Print());

            //tree.Insert(4);
            //tree.Insert(1);
            //tree.Insert(9);
            //tree.Insert(6);
            //tree.Insert(10);
            //tree.Insert(7);
            //tree.Insert(5);
            //Console.WriteLine(tree.Print());
            //tree._root = tree.BlRot(tree._root);
            //Console.WriteLine(tree.Print());
            /*
            Console.WriteLine("MinValueRec: " + tree.MinValueRec());
            Console.WriteLine("MaxValueRec: " + tree.MaxValueRec());
            Console.WriteLine("MinValueItr: " + tree.MinValueItr());
            Console.WriteLine("MaxValueItr: " + tree.MaxValueItr());
            Console.WriteLine("Size: "+ tree.Size());
            Console.WriteLine(tree.Contains(-5));
            Console.WriteLine(tree.Contains(5));
            Console.WriteLine("LeafCount: " +tree.LeafCount());*/
            //Console.WriteLine("GetHeight: "+tree.GetHeight());
            //tree.reorder_to_ideal();
            //Console.WriteLine("GetHeight: "+tree.GetHeight());
            //tree.Print();
            //tree.CreateList(list);
            /*foreach (int p in list) {
                Console.Write(p+" ");
            }*/
            //Console.WriteLine(tree.GetHeight());
            //tree.Clear();
            /*var init = Enumerable.Range(0, 1000000).OrderBy(x => rnd.Next()).ToArray();
            foreach (var i in init) {
                tree.Insert(i);
            }*/
            /*Console.WriteLine(tree.GetHeight());
            tree.reorder_to_ideal();
            Console.WriteLine(tree.GetHeight());*/
        }
    }
}

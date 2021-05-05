using System;

namespace Дерево
{
    internal class Program
    {
        private static Tree tree = new Tree();

        public static void Main(string[] args)
        {
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(20);
            tree.Insert(21);
            tree.Insert(19);
            Console.WriteLine("MinValueRec: " + tree.MinValueRec());
            Console.WriteLine("MaxValueRec: " + tree.MaxValueRec());
            Console.WriteLine("MinValueItr: " + tree.MinValueItr());
            Console.WriteLine("MaxValueItr: " + tree.MaxValueItr());
            Console.WriteLine("Size: " + tree.Size());
            Console.WriteLine(tree.Contains(-5));
            Console.WriteLine(tree.Contains(5));
            Console.WriteLine("LeafCount: " + tree.LeafCount());
            Console.WriteLine("GetHeight: " + tree.GetHeight());
            tree.print();
        }
    }
}

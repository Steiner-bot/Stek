using System;

namespace DVL
{
    class Program
    {
        private static Tree tree = new Tree();
        public static void Main(string[] args)
        {
            tree.Insert(4);
            tree.Insert(1);
            tree.Insert(9);
            tree.Insert(6);
            tree.Insert(10);
            tree.Insert(7);
            tree.Insert(5);
            Console.WriteLine(tree.Print());
        }
    }
}

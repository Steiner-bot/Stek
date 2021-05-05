using System;
using System.Collections.Generic;
namespace _4_Задание
{
    internal class Program
    {
        static KeyVal[] m = new KeyVal[5];
        static MyComp _myComp = new MyComp();
        private static List<int> lst = new List<int>() { 0, 1, 2, 3, 4, 5 };

        delegate int g(int a, int b);

        public static void Main(string[] args)
        {
            _myComp = new MyComp();
            m[0] = new KeyVal(2, 5);
            m[1] = new KeyVal(9, 8);
            m[2] = new KeyVal(2, 6);
            m[3] = new KeyVal(5, 7);
            m[4] = new KeyVal(10, 1);
            //Array.Sort(m, new MyComp());
            /*foreach (KeyVal keyVal in m) {
                Console.Write(keyVal.x + "," + keyVal.y + " ");
            }*/
            /*g sum = (x, y) => x + y;
            Action<int> aa = null;
            aa = x => Console.Write(x);
            aa(5);*/

            /*Func<int, int> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x + 2) : x;
            Console.WriteLine(fib(10));*/

            Array.Sort(m, (a, b) => a.y.CompareTo(b.y));
            foreach (KeyVal keyVal in m)
                Console.Write(keyVal.x + "," + keyVal.y + " ");
            Console.WriteLine();
            Console.WriteLine(lst.FindIndex(x => x == 5));
            lst.ForEach(x => Console.WriteLine(x));
        }
    }
}

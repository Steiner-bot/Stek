using System;

namespace StackCalc {
    internal class Program {
        public static void Main(string[] args) {
            while (true) {
                Console.Write("Введите выражение: ");
                string input = Console.ReadLine();
                if (input=="exit")
                    Environment.Exit(0);
                Console.Write("Обратная польская запись: ");
                Console.WriteLine(RPN.GetExpression(input));
                Console.Write("Результат: ");
                Console.WriteLine(RPN.Calculate(input));
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace StackCalc {
    public class RPN {
        public static double Calculate(string input) {
            return Counting(GetExpression(input));
        }

        public static string GetExpression(string input) {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>(); //стек для хранения операторов
            for (int i = 0; i < input.Length; i++) {
                if (IsDelimeter(input[i]))
                    continue;
                if (Char.IsDigit(input[i])) //Читаем до разделителя или оператора, что бы получить число
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i])) {
                        output += input[i];
                        i++; //  след. символу после добавления цифры в выражение
                        if (i == input.Length)
                            break;
                    }
                    output += " ";
                    i--; //возврат к символу перед разделителем
                }

                //теперь надо проверить, что это за символ
                if (IsOperator(input[i])) {
                    if (input[i] == '(')
                        operStack.Push(input[i]);
                    else if (input[i] == ')') {
                        //надо выписать все операторы внутри скобок
                        char s = operStack.Pop();
                        while (s != '(') {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    // Если это НЕ скобка 
                    else {
                        if (operStack.Count > 0)
                            //если есть операторы в стеке, то добавляем в строку
                            //оператор с наивысшим приоритетом
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                                output += operStack.Pop() + " ";
                        //иначе текущий оператор попадает в стек
                        operStack.Push(char.Parse(input[i].ToString()));
                    }
                }
            }

            while (operStack.Count > 0) {
                output += operStack.Pop() + " ";
            }

            return output;
        }

        private static double Counting(string input) {
            double result = 0;
            Stack<double> tmp = new Stack<double>();
            for (int i = 0; i < input.Length; i++) {
                if (Char.IsDigit(input[i])) {
                    string a = "";
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i])) {
                        a += input[i];
                        i++;
                        if (i == input.Length)
                            break;
                    }

                    tmp.Push(Convert.ToDouble(a)); //записываем число в стек
                    i--;
                }
                else if (IsOperator(input[i])) {
                    double a = tmp.Pop(); //1 операнд
                    double b = tmp.Pop(); //2 операнд
                    switch (input[i]) {
                        case '+':
                            tmp.Push(b + a);
                            //result = b + a;
                            break;
                        case '-':
                            tmp.Push(b - a);
                            //result = b - a;
                            break;
                        case '*':
                            tmp.Push(b * a);
                            break;
                        case '/':
                            tmp.Push(b / a);
                            break;
                        case '^':
                            //tmp.Push(Math.Pow(b, a));
                            tmp.Push(double.Parse(Math.Pow(double.Parse(b.ToString()),
                                double.Parse(a.ToString())).ToString()));
                            break;
                    }

                    //tmp.Push(result);
                }
            }

            return tmp.Peek();
        }

        private static bool IsDelimeter(char c) {
            if (" =".IndexOf(c) != -1)
                return true;
            return false;
        }

        private static bool IsOperator(char c) {
            if ("+-/*^()".IndexOf(c) != -1)
                return true;
            return false;
        }

        private static byte GetPriority(char s) {
            switch (s) {
                case '(': 
                    return 0;
                case ')':
                    return 1;
                case '+':
                    return 2;
                case '-':
                    return 3;
                case '*':
                    return 4;
                case '/':
                    return 4;
                case '^':
                    return 5;
                default:
                    return 6;
            }
        }
    }
}
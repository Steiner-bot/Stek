using System;

namespace FirstSeminar {
    public class MyStack {
        public int[] stackArray;
        public int countOfElements;

        public MyStack() {
            //stackArray = new int [1];
            countOfElements = 0;
        }

        public void Push(int x) {
            ++countOfElements;
            Array.Resize(ref stackArray, countOfElements);
            stackArray[countOfElements-1] = x;
        }

        public int Pop() {
            int tmp = stackArray[countOfElements];
            //stackArray[countOfElements] = 0;
            Array.Resize(ref stackArray, --countOfElements);
            return tmp;
        }

        public int Peek() {
            return stackArray[countOfElements];
        }
        
        public bool IsEmpty() {
            return countOfElements == 0;
        }
    }
}
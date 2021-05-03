using System;
using System.Diagnostics.Eventing.Reader;

namespace FirstSeminar {
    public class MyStack2<T> {
        int size = 0;
        T[] data = new T[0];

        public void Push(T x) {
            Array.Resize(ref data, ++size);
            data[size - 1] = x;
        }

        public void Pop() {
            if (size != 0) {
                Array.Resize(ref data, --size);
            }
        }

        public T Peek() {
            return size > 0 ? data[size - 1] : default(T);
        }

        public bool IsEmpty() {
            return size == 0;
        }

        public void Clear() {
            size = 0;
            data = new T[0];
        }
    }
}
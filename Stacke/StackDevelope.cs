using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
        class StackDevelope<T>(int size)
        {
            private readonly T[] _a = new T[size];
            private readonly int Size = size;
            private int LastIndex = -1;

            public bool Append(T element)
            {
                if (IsFull())
                    return false;

                _a[++LastIndex] = element;

                return true;
            }
            public T? Pop()
            {
                if (IsEmpty())
                    return default;

                return _a[LastIndex--];
            }

            public bool IsEmpty() => LastIndex == -1;
            public bool IsFull() => LastIndex == Size - 1;
            public T Peek() => _a[LastIndex];
        }

}

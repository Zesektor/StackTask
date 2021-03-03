using System;
using System.Collections.Generic;
using System.Text;

namespace StackTask
{
    public class MyStack<T> : IStack<T>
    {
        private int _i;

        private T[] array;

        public MyStack()
        {
            _i = -1;
            array = new T[1000];
        }

        public void Push(T x)
        {
            _i++;
            array[_i] = x;
        }

        public T Pop()
        {
            if (_i == -1) return default(T);
            var result = array[_i];
            _i--;
            return result;
        }

        public bool IsEmpty()
        {
            return _i == -1;
        }

        public MyStack<T> Reverse()
        {
            var newStack = new MyStack<T>();
            for (int i = _i; i >= 0; i--)
            {
                newStack.Push(array[i]);
            }

            return newStack;
        }
    }

    public interface IStack<T>
    {
        void Push(T x);
        T Pop();
        bool IsEmpty();
        MyStack<T> Reverse();
    }
}

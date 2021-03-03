using System;

namespace StackTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new MyStack<string>();
            s.Push("a");
            s.Push("b");
            s.Push("c");
            s.Push("d");
            s.Push("e");

            var el = s.Pop();
            Console.WriteLine(el);

            el = s.Pop();
            Console.WriteLine(el);

            Console.WriteLine("----------------------");

            var newStack = s.Reverse();
            while (!newStack.IsEmpty())
            {
                var newEl = newStack.Pop();
                Console.WriteLine(newEl);
            }

            Console.ReadKey();
        }
    }
}

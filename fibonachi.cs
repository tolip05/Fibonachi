using System;
using System.Collections.Generic;

namespace fibonachi
{
    class fibonachi
    {
        static void Main(string[] args)
        {
            Stack<long> fibonachi = new Stack<long>();
            int n = int.Parse(Console.ReadLine());

            fibonachi.Push(0);
            fibonachi.Push(1);
            for (int i = 0; i < n - 1; i++)
            {
                long firstNumber = fibonachi.Pop();
                long secondNumber = fibonachi.Peek();

                fibonachi.Push(firstNumber);
                fibonachi.Push(firstNumber + secondNumber);
            }
            Console.WriteLine(fibonachi.Pop());
        }
    }
}

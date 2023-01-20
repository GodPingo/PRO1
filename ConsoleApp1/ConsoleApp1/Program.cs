using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for (int N = 0;N<10; N++)
            {
                a = (N + 1) * (N - 1);
                Console.WriteLine(a);
            }
        }
    }
}
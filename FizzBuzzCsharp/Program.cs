using System;

namespace FizzBuzzCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var output = String.Empty;
                output += i % 3 == 0 ? "Fizz" : "";
                output += i % 5 == 0 ? "Buzz" : "";
                Console.WriteLine(output == String.Empty ? i.ToString() : output);
            }
            Console.ReadKey();
        }
    }
}

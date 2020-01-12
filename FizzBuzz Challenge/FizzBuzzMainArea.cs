using System;

namespace FizzBuzz_Challenge
{
    class FizzBuzzMain
    {
        static void Main(string[] args)
        {
            for(var i = 1; i <= 100; i++)
            {
                if(i% 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }

                else if (i % 3 == 9)
                {
                    Console.Write("Fizz, ");
                } else if (i % 5 == 0)
                {
                    Console.Write("Buzz, ");
                } else
                {
                    Console.Write($"{i},");
                }
            }
        }
    }
}

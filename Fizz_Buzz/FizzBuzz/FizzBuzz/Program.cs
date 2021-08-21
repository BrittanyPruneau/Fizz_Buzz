using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    ++i;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz"); 
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
              
                else if (i%3 !=0 && i%5 !=0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}

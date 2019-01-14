using System;
using System.Collections;

namespace FibonacciSequenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciSequense = new ArrayList() {0,1};
            int fibonacciNumber;
            var date = DateTime.Now.Day;

            for (int i = 1; i < Convert.ToUInt32(date.ToString()) -1; i++)
                {
                fibonacciNumber = (int)fibonacciSequense[i - 1] + (int)fibonacciSequense[i];
                fibonacciSequense.Add(fibonacciNumber);
                }

            if (date == 1)
            {
                Console.Write(fibonacciSequense[date] + " ");
            }
            else
            {
                foreach (int number in fibonacciSequense)
                {
                    Console.Write(number + " ");
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0Tymczyszyn
{
    internal class FizzBuzz
    {
        public FizzBuzz(int _maxValue) => maxValue = _maxValue;
        public int maxValue { get; set; }
        public void displayResult()
        {
            for (int  number = 1; number < maxValue; number++)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }

    }
}

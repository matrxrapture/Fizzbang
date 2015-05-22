
using System;

namespace _0_0_Fizz_Bang
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }
        /// <summary>
        /// Prints FizzBuzz for multiple of 15 ,buzz for multiple of 5 and buzz for mulpples of 3
        /// </summary>
        private static void FizzBuzz()
        {
            string message = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    message = "FizzBuzz,";
                }
                else if (i % 3 == 0)
                {                    
                    message = "Fizz,";
                 
                }
                else if (i % 5 == 0)
                {   
                    message = "Buzz,";                 
                }
                else
                {
                    message = i + ",";
                }

            printMessage(message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Prints the message
        /// </summary>
        /// <param name="message">Message to be printed</param>
        private  static void printMessage(string message)
        {
            Console.Write(message);

        }

    }
}

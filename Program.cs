using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); // Add a newline for better readability

            // Using a while loop to print the first 10 even natural numbers
            Console.WriteLine("First 10 even natural numbers:");
            int evenNumber = 2;
            int evenCount = 0;
            while (evenCount < 10)
            {
                Console.Write(evenNumber + " ");
                evenNumber += 2;
                evenCount++;
            }

            Console.WriteLine(); // Add a newline for better readability

            // Using a do-while loop to print the first 10 odd natural numbers
            Console.WriteLine("First 10 odd natural numbers:");
            int oddNumber = 1;
            int oddCount = 0;
            do
            {
                Console.Write(oddNumber + " ");
                oddNumber += 2;
                oddCount++;
            } while (oddCount < 10);
              Console.ReadLine();
        }
    }
}

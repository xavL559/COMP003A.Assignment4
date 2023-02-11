/*
 * Author: Xavier Leftridge
 * Course: COMP-003A
 * Purpose: To learn looping statements
*/


using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whole;
            Console.Write("Enter a whole positive number: ");
            whole = Console.ReadLine();
            int limit = Convert.ToInt32(whole);

            string output;
            output = "#";

            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(output);
                }
                Console.Write("\n");
            }

            Console.WriteLine("********************************************");

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (string friend in friends)
            {
                Console.Write("\n");
                Console.Write(friend);
            }

            Console.Write("\n");
            Console.Write("********************************************");

            int counter = 0;

            do
            {
                Console.Write("\n");
                counter += 5;
                Console.Write(counter);
            } while (counter < 50);

            Console.Write("\n");
            Console.Write("********************************************");

            int counter2;
            counter2 = 1;
            
            int divisibleBy2(int counter2)
            {
                var divide2 = counter2 / 2;
                return divide2;
            }

            int divisibleBy5(int counter2)
            {
                var divide5 = counter2 / 5;
                return divide5;
            }

            int divisibleBy25(int counter2)
            {
                var divide25 = counter2 / 2&5;
                return divide25;
            }

            while (counter2 >= 20)
            {
                if (divisibleBy2(counter2) == 0)
                {
                    Console.Write("foo");
                }
                if (divisibleBy5(counter2) == 0)
                {
                    Console.Write("bar");
                }
                if (divisibleBy25(counter2) == 0)
                {
                    Console.Write("FooBar");
                }
                else
                    Console.WriteLine(counter2);
            }

            





        }
    }
}
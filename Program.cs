using System;

namespace ConsoleAppLoops;

 class Program
 {
     static void Main(string[] args)
     {
        //  Console.WriteLine("Hello, World!");
        // while loop
        // While a condition is true execute this block of code. It will do this until a condition is passed.

        int counter = 0; // the initializer
        while (counter < 10) // the condition
        {
            Console.WriteLine("Brilliant");
            counter ++; // the iterator
        }

        // do while
        // The first condition is handled and then the program repeats until the desired condition is met

        int car = 0; // this is the initializer
        do
        {
            Console.WriteLine("Range Rover");
            car ++;

        } while (car < 5); // the condition

        // for loops are a bit different
        // the initializer, condition and iterator all come in a single line

        for (int index = 0; index < 4; index++)
        {
            Console.WriteLine($"Hello, This is index {index}");

        }

        // find the sum of integers 1 through 20 that are divisible by 3
        int sum = 0;
        for (int i = 1; i < 20; i++)
        {
            if (i % 3 == 0)
            {

            Console.WriteLine(i);
            sum = sum + i;

            }
            else
            {

            }

        }
            Console.WriteLine($"The sum is {sum}");
     }
 }

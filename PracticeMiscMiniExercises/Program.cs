using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMiscMiniExercises
{
    //this will swap two numbers
    //not just print them swap, 
    //but actually swap

    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.Write("\nEnter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;
            //those three lines did this:
            //created a "holding place" for one number
            //then filled it with num1, then moved num2 into num1 spot
            //then took the temp/holding place num and put it in num2

            Console.Write("\nAfter swapping: ");
            Console.Write("\nFirst number: " + num1);
            Console.Write("\nSecond number: " + num2);
            Console.Read();
        }
    }
}

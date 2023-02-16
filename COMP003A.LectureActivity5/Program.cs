/*
    * Author: Vanessa Garcia
    * Course: COMP-003A
    * Purpose: Code for Lecture Activity 5
    */




using System.ComponentModel;
using System.Xml.Linq;

namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50,'*'));
            Console.WriteLine("Methods & XML Comments");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("/n");

            HelloWorld(); //call to HelloWorld ()
            HelloWorld("Grace Hopper"); // call to HelloWorld(string name)
            HelloWorld("Donald Knuth"); // call to HelloWorld(string name) again with a differnt parameter value
            HelloWorld("Alan Turing", DateTime.Now.Year - 1912); //call to  HelloWorld(string name, int inputAge), which is an overloaded method
            HelloWorld("Ada Lovelace", DateTime.Now.Year - 1815); //call to HelloWorld(string name, int inputAge) again
            HelloWorld("Charles Babbage", DateTime.Now.Year - 1791); // call to HelloWorld(string name, int inputAge) again

            Console.WriteLine("\n");
            Console.Write("Enter value for inputNumber1: ");
            decimal inputNumber1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter value for inputNumber2: ");
            decimal inputNumber2 = Convert.ToDecimal(Console.ReadLine());

            // call to Sum(decimal num1, decimal num2) and storing the return value in a variable
            decimal sum = Add(inputNumber1, inputNumber2);
            Console.WriteLine($"Summation: {sum}"); // output the value of sum to console

            // if you don't plan on using a variable, you can simplify the method call ike the lines below
            Console.WriteLine($"Subtraction: {Subtract(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Multiplication: {Multiply(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Division: {Divide(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Remainder: {Remainder(inputNumber1, inputNumber2)}");

            // methods can call other methods too
            // below is an example of a method calling itself, also known as recursion
            Console.WriteLine("\n");







        }







    }

}
/*
 * Author: David Solis
 * Course: COMP-003A
 * Purpose: Code for Lecture Activity 5
 * 
 */

namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Methods & XML Comments");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("\n");

            HelloWorld(); // call to HelloWorld()
            HelloWorld("Grace Hopper"); // call to HelloWorld(string name)
            HelloWorld("Donald Knuth"); // call to HelloWorld(string name) again with a different parameter value
            HelloWorld("Alan Turing", DateTime.Now.Year - 1912); // call to Hellowrld(string nmae, int inputAge), which is an overloaded method
            HelloWorld("Ada Lovelace", DateTime.Now.Year - 1815); // call to HelloWorld(string name, int inputAge) again
            HelloWorld("Charles Babbage", DateTime.Now.Year - 1791); // call to HelloWorld(string name, int inputAge) again

            Console.WriteLine("\n");
            Console.WriteLine("Enter vaue for inputNumber1: ");
            decimal inputNumber1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter value for inputNumber2: ");
            decimal inputNumber2 = Convert.ToDecimal(Console.ReadLine());

            // call to Sum(decimal num1, deciaml num2) and storing the return value n a variable
            decimal sum = Add(inputNumber1, inputNumber2);
            Console.WriteLine($"Summation: {sum}"); // output the value of sum to console

            // if you don't plan on using a variable, you can simplify the method call like lines below
            Console.WriteLine($"Subtraction: {Subtract(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Multiplication: {IMultiplyOperators(inputNumber1)}");
            Console.WriteLine($"Division: {DivideByZeroException(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Remainder: {Remainder(inputNumber1, inputNumber2)}");

            // methods can call other methods too
            // below is an example of a method calling itself, also known as recursion
            Console.WriteLine("\n");
            Inception("This is inception level ", 5);
        } // Main() close


        /* XML comments are prefixed with three forward slashes '///'
         * if you type '///' on top of a class or method,
         * visual studio will populate the structure for you
         * otherwise, you would have to use the following opening AND closing tags (similar to most html elements)
         * <summary></summary> used to describe a type member
         * <param name="nameOfTheParameter"></param> used for describing one or more parameters in the method signature
         * <returns></returns> used to describe the return value
         * 
         * there are other tags in https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
         */


        //NOTE: Method definitions are programmed inside the clas { } code block, not inside Main() { }
        /// <summary>
        /// Method without parameters and return value
        /// <summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Method overloading with one parameter but no return value
        /// Method overloading => same method name but different signature (different parameter)
        /// </summary>
        /// <param name="inputName">String input</param>
        static void HelloWorld(string inputName)
        {
            Console.WriteLine($"Hello, {inputName}");
        }

        /// <summary>
        /// Method overloading with multiple parameters but no return value
        /// </summary>
        /// <param name="inputName">String input</param>
        /// <param name="inputName">Integer input</param>
        static void HelloWorld(string inputName, int inutNumber)
        {
            Console.WriteLine($"Hello, {inputName}, age {inputName}");
            // you can add more code here
        }

        /// <summary>
        /// Method for addig two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Sum of two decimal inputs</returns>
        /// static decimal Add(decimal num1, decimal num2)
        }
            // you can add more code here before the return statement
            return num1 + num2;
        }

        /// <summary>
        /// Method for subtracting two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2"Decimal input</param>
        /// returns>Difference of two decimal inputs</returns>
        static deciaml Subtract(decimal num1, decimal num2)
        {
        return num1 - num2;
        }
        
        /// <summary>
        /// Method for multiplying two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Product of two decimal inputs</returns>
        /// static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// Method for dividing two numeric variables
        /// <summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2"> Decimal input</param>
        /// <returns>Quotient of two decimal inputs<returns>
        static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        ///<summary>
        ///Method for dividing two numeric variables
        ///</summary>
        ///<param name="num1">Decimal input</param>
        ///<param name="num2">Decimal input</param>
        ///<returns>Remainer after dividing two decimal input</returns>
        static decimal Remainder(decimal num1, decimal num2)
        {
            return num1 % num2;
        }

        ///<summary>
        ///Recursive
        ///</summary>
        ///<param name="message">String input to print to console</param>
        ///<param name="counter">Integer input used as a looping counter</param>
        static void Inception(string message, int counter)
        {
            Console.WriteLine($"{message} {counter}");
            counter--;
            if(counter >=0) Inception(message, counter);
        }
    }
}

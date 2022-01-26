/*
 * Darren Fisher
 * MIS 3033
 * HW1 task5 
 */

/*
1. The first method that you will need to create is to calculate the y value of a line, given 
by the slope(m), the x value (x) and the y intercept (b).  Your method should be named 
LineValueForY with a return type of double.  Y.  Your method should accept 3 
parameters, all of type double.  The first parameter will be the slope of the line (name 
this parameter m), the second parameter should be the x value (name this parameter x) 
and the last parameter should be the y intercept (name this parameter b).  The formula 
to calculate the Y value is Y = mx + b

2. The second method that you will need to create is to calculate the factorial of a 
number.  Your method name should be Factorial and should have a return type of 
int.  Your method should accept a single parameter of type int.  To calculate the factorial 
of a number, you multiply it by every number before it.e.g. 5 factorial = 5 * 4 * 3 * 2 * 1 = 
120
*/

using System;

namespace taskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            // get M, X, and B from user
            Console.WriteLine("Enter the slope m of the graph");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the x value");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y-intercept");
            double b = Convert.ToDouble(Console.ReadLine());

            // call method to get y value 
            double y = LineValueForY(m, x, b);

            // print out desired y value 
            Console.WriteLine("The y value of the line is: " + y);

            // get a number to calculate factorial
            Console.WriteLine("Enter a number to find the factorial");
            int factorialNum = Convert.ToInt32(Console.ReadLine());

            // calls method to calculate
            int factorialAnswer = Factorial(factorialNum);

            // print out factorial and the solution
            Console.WriteLine("The factorial of " + factorialNum + " is: " + factorialAnswer);

            Console.ReadKey();
        }

        // calculate y based on slope(m), the x value (x) and the y intercept (b)
        static double LineValueForY(double m, double x, double b)
        {

            // y = mx + b
            double y = m * x + b;
            return y;
        }

        // To calculate the factorial 
        static int Factorial(int factorial)
        {
            int answerFactorial = 1;

            for (int x = 1; x <= factorial; x++)
            {
                answerFactorial = answerFactorial * x;
            }

            return answerFactorial;
        }

    }
}
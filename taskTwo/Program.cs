// See https://aka.ms/new-console-template for more information
/*
 * Darren Fisher
 * Homework 1
 * task 1
 * 1/25/2022
 */

/*
 Create an application that will keep prompting the user to input all 3 of their exam 
grades (using a For loop).  Calculate the average of their exam scores and output the 
result.  When you display the result, make sure to use a Format Specifier for 
percentages.
 */

using System;

namespace taskTwo
{
    class program
    {

        static void Main(String[] args)
        {
            // array to hold the grades
            double[] grades = new double[3];

            // for loop to iterate 3x and grab grades from the user
            double averageGrade = 0;
            for (int x = 0; x < grades.Length; x++)
            {
                Console.WriteLine("Enter your " + (x+1) + " grade");
                grades[x] = Convert.ToDouble(Console.ReadLine());
                averageGrade = averageGrade + grades[x];
            }

            // get avg grades 
            averageGrade = averageGrade/ grades.Length;

            // print out average grade
            Console.WriteLine("Your average grade for this semester was {0:F2}", averageGrade);

            Console.ReadKey();
        }
    }
}        


            

          
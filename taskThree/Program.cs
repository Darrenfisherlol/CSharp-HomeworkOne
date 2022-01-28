/*
 * Darren Fisher
 * MIS 3033
 * HW 1
 * Task 3
 */

/*
Create an application that asks the user for their exam score, add their input to an 
accumulator and then ask the user if they have another score to enter.  If they do, ask 
for the exam score and repeat the process until they say no.

Make sure that their answer is case insensitive (e.g. they can say Yes or yes and your code treats it the 
same).
Once they say no, calculate the average of all of the exam scores based upon 
your accumulator and your counting variable.

Make sure that you use some sort of Loop, an accumulating variable (to keep track of 
the total exam scores), and a counting variable (to keep track of the number of scores 
they entered).
*/

using System;
using System.Collections.Generic;

namespace hwOneMacVersion
{
    class Program
    {
        static void Main(string[] args)
        {

            // collection list for grades
            List<double> listOfGrade = new List<double> { };

            //
            int numOfEnteredValues = 0;
            // welcome usser and declair constant for do while loop
            Console.WriteLine("Hey user, enter your grades and exit by typing \"yes\" when asked");
            string continueLoop = "yes";

            // Do while loop to get grades and stop once user types "no"
            do
            {
                // add grade to list
                Console.WriteLine("Enter your grade");
                listOfGrade.Add(Convert.ToDouble(Console.ReadLine()));

                // record amount of num entered
                numOfEnteredValues++;

                // see if user wants to enter more
                Console.WriteLine("Do you want to continue? yes or no.");
                continueLoop = Console.ReadLine().ToLower();

            } while (continueLoop == "yes");

            // avg grades variable 
            double averageGrade = 0;

            // iterate through list and find averagfe
            for (int x = 0; x < listOfGrade.Count; x++)
            {
                averageGrade = averageGrade + listOfGrade[x];
            }

            // calculate average & use the required # of values entered variable
            averageGrade = averageGrade / numOfEnteredValues;

            // outputs grades avg
            Console.WriteLine("Hey student, your average grade is " + averageGrade.ToString("F2"));

        }
    }
}
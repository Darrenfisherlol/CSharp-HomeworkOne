// See https://aka.ms/new-console-template for more information
/*
 * Darren Fisher
 * Homework 1
 * task 1
 * 1/25/2022
 */

/*
 You will be creating a console application to help our sales associates sell our main 
products, cogs and gears.  Cogs have a whole sale price of $79.99 and gears have a 
whole sale price of $250.00.  When our sales associates are selling to our customers on 
the floor, we have a standard 15% markup on our wholesale price for our sales 
price.  However, if the customer purchases more than 10 of either item or a combined 
quantity of 16 items we only markup the items by 12.5%.  On top of this, the sales tax 
for all sales is 8.9%.

 Create a console application that will prompt the sales associate for the number 
of cogs as well as the number of gears for a sales order.  

 Create class level constant variables for the whole sale prices for the items as 
well as the markup percentages. 

 Once the user has input all of the data, create a receipt and display the total cost 
for the items, the discount amount, the sales tax amount as well as the grand 
total.  

 */

using System;

namespace taskOne
{

    class program
    {
        // created constants for our application

        // whole sale price constant
        const double cogsSalePrice = 79.99;
        const double gearsSalePrice = 250;

        // our markup constants
        const double standardMarkup = .15;
        const double bulkMarkup = .125;

        static void Main(string[] args)
        {

            // constant variable ~ not class wide
            double salesTax = .089;

            // gets numbers of cogs by calling method 
            int numberOfCogs = getNumCogs();

            // gets number of gears by calling method
            int numberOfGEars = getNumGears();

            // total amount of items purchased
            int combinedItemsPurchased = numberOfGEars + numberOfCogs;

            // created variables to print receipt: total price, sales tax, discount amount, and grant total
            double totalCostPre;
            double markupPrice;
            double salesTaxAmount;
            double grandTotal;

            // conditional statement to find if the amount purhcased is >= 10 or 16
            if (numberOfCogs > 10 || numberOfGEars > 10 || combinedItemsPurchased >= 16)
            {
                // total pre tax and markup cost
                totalCostPre = (numberOfCogs * cogsSalePrice + numberOfGEars * gearsSalePrice);

                // discount(difference) between standard markup 15% and high purchaser 12.5% markup
                markupPrice = (totalCostPre * standardMarkup) - (totalCostPre * bulkMarkup);
                // sales tax amount
                salesTaxAmount =  (totalCostPre + markupPrice) * salesTax;

                // grand total amount
                grandTotal = salesTaxAmount + totalCostPre + markupPrice;
            }
            else
            {
                // total pre tax and markup cost
                totalCostPre = (numberOfCogs * cogsSalePrice + numberOfGEars * gearsSalePrice);

                // discount(difference) between standard markup 15% and high purchaser 12.5% markup
                markupPrice = (totalCostPre * standardMarkup) - (totalCostPre * standardMarkup);
                // sales tax amount
                salesTaxAmount = (totalCostPre + markupPrice) * salesTax;

                // grand total amount
                grandTotal = salesTaxAmount + totalCostPre + markupPrice;
            }

            // print receipt: total price, sales tax, discount amount, and grant total
            Console.WriteLine("Price pre tax and discount: " + totalCostPre.ToString("C2"));
            Console.WriteLine("Discount amount: " + markupPrice.ToString("C2"));
            Console.WriteLine("Sales tax amount: " + salesTaxAmount.ToString("C2"));
            Console.WriteLine("Grand total: " + grandTotal.ToString("C2"));

            Console.ReadKey();
        }

        // prompts sales associate for the number of cogs
        static int getNumCogs()
        {

            int numCogs;
            bool isNum = false;

            // do whileLoop to make sure the user enters a int number for cogs
            do
            {
                Console.WriteLine("Enter the amount of cogs you want to buy?");

                isNum = Int32.TryParse(Console.ReadLine(), out numCogs);

                if (!isNum)
                {
                    Console.WriteLine("Hey! that's not a whole number, give me an int");
                }

            } while (!isNum);

            return numCogs;
        }

        // prompts sales associate for the number of gears
        static int getNumGears()
        {

            int numGear;
            bool isNum = false;

            // do whileLoop to make sure the user enters a int number for gears
            Console.WriteLine("Enter the amount of gears you want to buy?");
            do
            {
                isNum = Int32.TryParse(Console.ReadLine(), out numGear);
                if (!isNum)
                {
                    Console.WriteLine("Hey! that's not a whole number, give me an int");
                }
            } while (!isNum);

            return numGear;
        }

    }
}

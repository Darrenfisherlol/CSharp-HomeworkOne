// See https://aka.ms/new-console-template for more information
/*
 * 
 * Darren Fisher
 * Homework 1
 * task 1
 * 1/25/2022
 
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
        const double wholeSalePrice = 79.99;

        // our markup constants
        const double standardMarkup = .15;
        const double bulkMarkup = .125;

        static void Main(String[] args)
        {
            // constant variable ~ not class wide
            double salesTax = .089;






        }


    }
}

/// Chapter No. 4		Exercise No. 2
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Sep 20, 2021
///
/// Problem Statement: Write a program (Console or GUI) that determines the change to be dispensed from a vending machine.
/// 
/// 
/// Overall Plan:
/// 1) Prompt the user for the amount of the item ( 5 cent increments up to a dollar) 
/// 2) Calculate everything with pennys 
/// 3) convert the amount of pennies each coin holds and save them as integers
/// 4) Starting with quarters use the value of the change and divide by the amount of pennies it holds (25)
/// 5) Next, enter the dime field by using the % sign with the change and the amount of quarters. 
/// 6) epeat this step again but with dimes and nickels as the factors .
/// 7) display the results to the user. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring the penny values
            int penniesPerDollar = 100, penniesPerQuart = 25, penniesPerDime = 10, penniesPerNickel = 5, moneyAmount, returned ;

            // asking user for the item price
            Console.WriteLine("How much does this item cost? (From 5 cents to $1 in 5-cent increments");
            moneyAmount = Int32.Parse(Console.ReadLine());

            //find how much change is needed 
            returned = penniesPerDollar - moneyAmount;
            Console.WriteLine("The item cost " + moneyAmount + " cents and you paid with $1 \n Your Change is: " + returned + " cents ");

            int quarters = returned / penniesPerQuart;
            returned %= penniesPerQuart;

            int dimes = returned / penniesPerDime;
            returned %= penniesPerDime;

            int nickels = returned / penniesPerNickel;

            Console.WriteLine(" Quarters " + quarters);
            Console.WriteLine(" Dimes " + dimes);
            Console.WriteLine(" nickels " + nickels);

            Console.ReadLine();

        }
    }
}

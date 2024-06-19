/*  Author : Koena Cedric Poopedi
   
    Description : (Calculating Sales) A website sells three products whose retail prices are as follows:
                  product 1, $2.98; product 2, $4.50; and product 3, $9.98.

    The program reads a series of pairs of numbers as follows:
    "a) product number b) quantity sold". 
    The uses a switch statement to determine the retail price for each product.
    It calculates and display the total retail value of all products sold.
    And Uses a sentinel-controlled loop to determine when the app should stop looping and display the final results.
*/


using System;
using static System.Console; //removing console infront of writeline


namespace RetailExercise;

class Program
{
    public static void Main(string[] args)
    {
       Sales sales = new Sales(); //declaring an instance of a class
        sales.CalculatingSales(); //calling a class method
    }
}


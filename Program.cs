using System;
using static System.Console; //removing console infront of writeline


namespace RetailExercise;

class Program
{
    public static void Main(string[] args)
    {
       Sales sales = new Sales();
        sales.CalculatingSales();
    }
}


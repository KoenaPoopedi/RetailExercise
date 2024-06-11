using System;
using static System.Console; //removing console infront of writeline


namespace CalculatingSales;

class Program
{
    public static void Main(string[] args)
    {
        double product1 = 2.98;
        double product2 = 4.50;
        double product3 = 9.98;
        double TotalPrice, OverallTotal = 0;

        int Productnumber, QuantitySold = 0, OverallQuantitySold =0;
        
        

        // loooping the code.
            while (true)
            {
            //handling all the exceptions that may occur
            try
            {
                //options for the user
                WriteLine("########################################################");
                WriteLine("Please Enter Your product number : 1 to 3 and -1 to Exit");
                WriteLine("Product 1 = $2.98");
                WriteLine("Product 2 = $4.50");
                WriteLine("Product 3 = $9.98");
                WriteLine("#########################################################");
                Productnumber = Convert.ToInt32(Console.ReadLine());

                //program termination
                if (Productnumber == -1)
                {
                    break;
                }


                switch (Productnumber)
                {
                    case 1:
                        {
                            WriteLine("Please enter your quanty :");
                            QuantitySold = Convert.ToInt32(Console.ReadLine());
                            TotalPrice = product1 * QuantitySold;
                            WriteLine("Your total price Is:" + TotalPrice);
                            break;
                        }
                    case 2:
                        {
                            WriteLine("Please enter your quanty :");
                            QuantitySold = Convert.ToInt32(Console.ReadLine());
                            TotalPrice = product2 * QuantitySold;
                            WriteLine("Your total price Is:" + TotalPrice);
                            break;
                        }
                    case 3:
                        {
                            WriteLine("Please enter your quanty :");
                            QuantitySold = Convert.ToInt32(Console.ReadLine());
                            TotalPrice = product3 * QuantitySold;
                            WriteLine("Your total price Is:" + TotalPrice);
                            break;
                        }
                    default:
                        {
                            WriteLine("Please input a valid product Number");
                            continue;
                        }

                }

                //incrementation of the final values of the customer.
                OverallTotal += TotalPrice;
                OverallQuantitySold += QuantitySold;
            }
            catch (Exception ex)
            {
                //user warning for entering a wrong input.
                WriteLine("Invalid imput: Please enter a valid Key!!!");
                ex.ToString();
            }
    }
            //displaying the final results for the user.
            WriteLine("Quantity that is sold is :" + OverallQuantitySold);
            WriteLine("Your Overall Total for all products is:" + OverallTotal);
    }
}


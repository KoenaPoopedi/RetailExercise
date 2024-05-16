using System;


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
        
        


            while (true)
            {

            try
            {
                Console.WriteLine("########################################################");
                Console.WriteLine("Please Enter Your product number : 1 to 3 and -1 to Exit");
                Console.WriteLine("Product 1 = $2.98");
                Console.WriteLine("Product 2 = $4.50");
                Console.WriteLine("Product 3 = $9.98");
                Console.WriteLine("#########################################################");
                Productnumber = Convert.ToInt32(Console.ReadLine());

                if (Productnumber == -1)
                {
                    break;
                }


                switch (Productnumber)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter your quanty :");
                            QuantitySold = Convert.ToInt32(Console.ReadLine());
                            TotalPrice = product1 * QuantitySold;
                            Console.WriteLine("Your total price Is:" + TotalPrice);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Please enter your quanty :");
                            QuantitySold = Convert.ToInt32(Console.ReadLine());
                            TotalPrice = product2 * QuantitySold;
                            Console.WriteLine("Your total price Is:" + TotalPrice);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter your quanty :");
                            QuantitySold = Convert.ToInt32(Console.ReadLine());
                            TotalPrice = product3 * QuantitySold;
                            Console.WriteLine("Your total price Is:" + TotalPrice);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please input a valid product Number");
                            continue;
                        }

                }

                OverallTotal += TotalPrice;
                OverallQuantitySold += QuantitySold;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid imput: Please enter a valid Key!!!");
            }
    }

            Console.WriteLine("Quantity that is sold is :" + OverallQuantitySold);
            Console.WriteLine("Your Overall Total for all products is:" + OverallTotal);
    }
}


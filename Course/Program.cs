using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tag = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tag == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (tag == 'c')
                {
                    list.Add(new Product(name, price));
                }

                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UserProduct(name, price, date)); 
                }
                Console.WriteLine();
                
            }

            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine();
            foreach(Product tags in list)
            {
                Console.WriteLine(tags.PriceTag().ToString());
                
            }
        }
    }
}

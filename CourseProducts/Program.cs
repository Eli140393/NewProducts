using System;
using System.Collections.Generic;
using CourseProducts.Entities;
using System.Globalization;
namespace CourseProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter number of products:  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufactured Date (DD/MM/YYYY): ");
                    DateTime ManufacturedDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, ManufacturedDate));
                }
                else
                {
                    list.Add(new Product(name, price));

                }
            }
                Console.WriteLine("PRICE TAGS: ");
                foreach (Product prod in list)
                {
                Console.WriteLine( prod.priceTag()); 
                }
            
        }
    }
}

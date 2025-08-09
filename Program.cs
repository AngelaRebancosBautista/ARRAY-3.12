using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June",
                          "July", "August", "September", "October", "November", "December" };

            float[] sales = new float[12];

            Console.WriteLine("Enter monthly sales data");

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"{months[i]}: ");
                while (!float.TryParse(Console.ReadLine(), out sales[i]) || sales[i] < 0)
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write($"{months[i]}: ");
                }
            }

            float maxSale = sales[0];
            float minSale = sales[0];
            int maxMonthIndex = 0;
            int minMonthIndex = 0;
            float total = 0;

            for (int i = 0; i < 12; i++)
            {
                total += sales[i];

                if (sales[i] > maxSale)
                {
                    maxSale = sales[i];
                    maxMonthIndex = i;
                }

                if (sales[i] < minSale)
                {
                    minSale = sales[i];
                    minMonthIndex = i;
                }
            }
            float average = total / 12;

            Console.WriteLine("\nSales Analysis Results");
            Console.WriteLine($"Highest sales: {months[maxMonthIndex]} with {maxSale}");
            Console.WriteLine($"Lowest sales: {months[minMonthIndex]} with {minSale}");
            Console.WriteLine($"Average monthly sales: {average}");
        }
    }
}
        


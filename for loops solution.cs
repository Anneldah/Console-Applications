using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCust,cust=1;
            double price, vat ,amtDue=0,total=0;
            Console.Write("Enter the number of customers: ");
            numCust = int.Parse(Console.ReadLine());
            for(int custy=1; cust <= numCust; cust++)
            {
                Console.Write("Enter the price of item purchased" + cust + ":");
                price = double.Parse(Console.ReadLine());
                vat = price * 15 / 100.0;
                amtDue = vat + price;
                Console.WriteLine("\nAmout due is: " + amtDue.ToString("C"));
                total += amtDue;
            }
            cust++;
    
            Console.WriteLine("\nGrand total ,ade by the store is: " +total.ToString("C"));
            Console.ReadLine();
        }
        
    }
}

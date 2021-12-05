using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, breadth, surface,charge=0,total=0;
            int numOfD;
            const double minCharge = 1200;
            string typeOfW = "";
            Console.Write("Enter the length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the breadth: ");
            breadth = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of drawers: ");
            numOfD = int.Parse(Console.ReadLine());
            Console.Write("Enter the type of wood: ");
            typeOfW = Console.ReadLine();
            surface = length * breadth;
            if (surface > 700000)

            {
                charge = minCharge + 300;


            }
            numOfD = numOfD+ (numOfD*180);
            if (typeOfW == "Mohogany" || typeOfW == "Cherry")
            {

                charge = minCharge + 900;
                {
                    if (typeOfW == "Öak")
                    {
                        charge = minCharge + 750;

                    }
                }


            }
            else
                charge = minCharge + 0;

            total += charge;
            Console.WriteLine("Total is:" + charge.ToString("C"));
            Console.ReadKey();
        }
        
            
    }
}

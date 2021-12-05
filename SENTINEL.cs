using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char initial;
            string person = "";
            double sales=0, salesC = 0, salesM = 0, salesZ = 0;
            double comC = 0, comZ = 0, comM = 0;
            Console.WriteLine("Enter your initial [Type X to end]: ");
            initial = Convert.ToChar(Console.ReadLine());
            while (initial != 'X')
            {
                if (initial == 'M')
                {
                    person = "Mandisa";
                    Console.Write("Enter your sales amount" + person + ":");
                    sales = double.Parse(Console.ReadLine());
                    salesM += sales;
                    comM = comM + (sales * 0.1);
                }
                else if (initial == 'Z')
                {
                    person = "Zinhle";
                    Console.Write("Enter your sales" + person + ":");
                    sales = double.Parse(Console.ReadLine());
                    salesZ += sales;
                    comZ = comZ + (sales * 0.1);


                }
                else
                {
                    person = "Cyril";
                    Console.Write("Enter sales sold" + person + ":");
                    sales = double.Parse(Console.ReadLine());
                    salesC += sales;
                    comC = comC + (sales * 0.1);
                }
                Console.Write("Enter your initial [Gype X to end]: ");
                initial = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Mandisa sold " + salesM.ToString("C") + "and made the total of" + comM.ToString("C"));
            Console.WriteLine("Zinhle sold " + salesZ.ToString("C") + "and made the total of" + comZ.ToString("C"));
            Console.WriteLine("Cyril sold " + salesC.ToString("C") + "and made the total of" + comC.ToString("C"));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables//
            string TicketSales;
            double AdultTicketsNeeded;
            double ChildTicketsNeeded;
            double AdultOnlyTotal;
            double ChildOnlyTotal;
            const double AdultTicketPrice = 3.75d;
            const double ChildTicketPrice = 2.25d;
            double TotalCost;

            //Codes//
            Console.WriteLine("\"Welcome to Program5\"");
            Console.WriteLine();
            Console.WriteLine("Adult Tickets cost $3.75 and Child Tickets cost $2.25");
            Console.WriteLine();
            Console.Write("How many Adult ticket(s) do you need? : ");
            TicketSales = Console.ReadLine();
            AdultTicketsNeeded = Convert.ToDouble(TicketSales);
            AdultOnlyTotal = AdultTicketsNeeded * AdultTicketPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The Cost of {0} Adult Ticket(s) is {1:c2}", AdultTicketsNeeded, AdultOnlyTotal);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("How many Child ticket(s) do you need? : ");
            TicketSales = Console.ReadLine();
            ChildTicketsNeeded = Convert.ToDouble(TicketSales);
            ChildOnlyTotal = ChildTicketsNeeded * ChildTicketPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The Cost of {0} Child Ticket(s) is {1:c2}", ChildTicketsNeeded, ChildOnlyTotal);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            TotalCost = AdultOnlyTotal + ChildOnlyTotal;
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Your Total Cost of {0} Adult Ticket(s) and {1} Child Ticket(s) is {2:c2}", AdultTicketsNeeded, ChildTicketsNeeded, TotalCost);
            Console.WriteLine("=========================================================================");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

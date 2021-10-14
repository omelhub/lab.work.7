using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander commander = new Commander();
            commander.PrintTeam();
            Console.WriteLine();
            commander.PrintBageForAllCashiers();
            Console.WriteLine();

            commander.PrintBage(cashier: new Cashier());
            Console.ReadKey();
        }
    }
}

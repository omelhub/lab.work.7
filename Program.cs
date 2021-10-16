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
            Cashier cash1 = new Cashier() {FirstName = "Bill", LastName = "Klinton", Qualification = "стажер"};
            commander.All.Add(cash1);
            Cashier cash2 = new Cashier() { FirstName = "Max", LastName = "Brant", Qualification = "кассир"};
            commander.All.Add(cash2);
            Loader load1 = new Loader() { FirstName = "Winston", LastName = "Smith" };
            commander.All.Add(load1);
            Cashier cash3 = new Cashier() { FirstName = "Chad", LastName = "Kroeger", Qualification = "старший кассир"};
            commander.All.Add(cash3);
            Loader load2 = new Loader() { FirstName = "Ryan", LastName = "Peake" };
            commander.All.Add(load2);
            Cashier cash4 = new Cashier() { FirstName = "Mike", LastName = "Kroeger", Qualification = "кассир"};
            commander.All.Add(cash4);
            Loader load3 = new Loader() { FirstName = "Daniel", LastName = "Adair" };
            commander.All.Add(load3);
            Cashier cash5 = new Cashier() { FirstName = "Brandon", LastName = "Kroeger", Qualification = "стажер"};
            commander.All.Add(cash5);

            int i = 0;
            foreach (var VARIABLE in commander.All)
            {
                if (i % 2 == 0)
                    commander.Tomorrow.Add(VARIABLE);
                i++;
            }

            commander.PrintTeam();//список на завтра
            Console.WriteLine();
            
            commander.PrintBageForAllCashiers();
            Console.WriteLine();

            Console.WriteLine(commander.PrintBage(cash1));//кассир + квалификация
            Console.ReadKey();
        }
    }
}

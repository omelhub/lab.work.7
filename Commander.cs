using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._7
{
    public class Commander
    {
        public List<Employee> All { set; get; } = new List<Employee>();
        public List<Employee> Tomorrow { set; get; } = new List<Employee>();

        public Commander()
        {
            All.Add(new Cashier() { FirstName = "Bill", LastName = "Klinton" });
            All.Add(new Cashier() { FirstName = "Max", LastName = "Brant" });
            All.Add(new Loader() { FirstName = "Winston", LastName = "Smith" });
            All.Add(new Cashier() { FirstName = "Chad", LastName = "Kroeger" });
            All.Add(new Loader() { FirstName = "Ryan", LastName = "Peake" });
            All.Add(new Cashier() { FirstName = "Mike", LastName = "Kroeger" });
            All.Add(new Loader() { FirstName = "Daniel", LastName = "Adair" });
            All.Add(new Cashier() { FirstName = "Brandon", LastName = "Kroeger" });
            int i = 0;
            foreach (var VARIABLE in All)
            {
                if (i % 2 == 0)
                    Tomorrow.Add(VARIABLE);
                i++;
            }
        }

        public void PrintTeam()
        {
            foreach (var employee in Tomorrow)
            {
                Console.WriteLine(employee.GetFullName());
            } //пробегается по коллекции сотрудников и выводит фамилию имя
        }
            
        public void PrintBage(Cashier cashier)
        {
            foreach (var employee in Tomorrow)
            {
                Console.WriteLine(employee.GetFullName());
            }
        }

        public void PrintBageForAllCashiers()
        {
            foreach (var employee in All)
            {
                if (employee is Cashier)
                    Console.WriteLine(employee.GetFullName());
            } //пробег по коллекции и печатает если кассир
        }
        
    }

}

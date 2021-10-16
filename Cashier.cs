using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._7
{
    public class Cashier : Employee
    {
        private string _q;
        public string Qualification
        {
            set
            {

                if (value == "стажер" | value == "кассир" | value == "старший кассир")
                    _q = value;
                else
                    Console.WriteLine("Ошибка");
            }
            get { return _q; }
        }
        public new string GetFullName() => base.GetFullName() + " " + Qualification;

    }
}
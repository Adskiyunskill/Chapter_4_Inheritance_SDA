using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Inheritance_SDA
{

    class CL_Company
    {
        public string name;
        public int persons;
        public int money;
        public void show()
        {
            Console.WriteLine("Company.show: Базовый класс");
        }
        public int averageSalary()
        {
            return money / persons;
        }
        public int maxPersons (int salary)
        {
            return money / persons;
        }
        public int minus (int minus1, int minus2)
        {
            return money * (minus1 + minus2) / 100;
        }
    }
}

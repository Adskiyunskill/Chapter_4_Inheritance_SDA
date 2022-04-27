using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Inheritance_SDA
{

    class Company
    {
        public string name;
        public int persons;
        public int money;
        public Company (string name, int persons, int money)
        {
            this.name = name;
            this.persons = persons;
            this.money = money;
            
        }
        public string Name
        {
            get { return name; }
        }
        public void show()
        {
            Console.WriteLine("В компании " + name + " трудятся " + persons + " сотрудников " + " фонд зарплаты " + money);
        }
        public int averageSalary()
        {
            return money / persons;
        }
        public int maxPersons(int salary)
        {
            return money / persons;
        }
        public int minus
            (int minus1, int minus2)
        {
            return money * (minus1 + minus2) * 100;
        }
    }
}

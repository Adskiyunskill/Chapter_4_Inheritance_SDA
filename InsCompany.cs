using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Inheritance_SDA
{

    class Cl_InsCompany : Program
    {
        int counts;
        int summaplus;
        int summaminus;
        public int averageInsSumma()
        {
            return summaplus / counts;
        }
        new public void show()
        {
            Console.WriteLine("InsCompany.show: производный класс");
        }
    }
}

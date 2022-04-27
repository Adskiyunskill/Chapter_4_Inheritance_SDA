using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Inheritance_SDA
{
    class Program
    {
        static void Main(string[] args)
        {
            CL_Company ob = new CL_Company();
            ob.show();
            Cl_InsCompany ob1 = new Cl_InsCompany();
            ob1.show();
            Console.ReadKey();
        }
    }
}

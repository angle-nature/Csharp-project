using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class UEmployee:Employee
    {
        public override double getSalary()
        {
            return 1.5 * (BaseSalary + Time * 30);
        }
    }
}

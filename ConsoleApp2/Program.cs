using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public delegate void MyDel(double a, double b);

        public static void squareSum(double a, double b)
        {
            Console.WriteLine(a + "和" + b + "的平方和为：" + (a * a + b * b));
        }

        public static void squareSub(double a, double b)
        {
            Console.WriteLine(a + "和" + b + "的平方差为：" + (a * a - b * b));
        }

        static void Main(string[] args)
        {
            
                Employee e = new Employee();
                UEmployee ue = new UEmployee();
                e.setTime(15);
                ue.setTime(8);

                Console.WriteLine("普通职工：");
                Console.WriteLine("工作年数：" + e.getTime());
                Console.WriteLine("该普通职工工资：" + e.getSalary());

                Console.WriteLine("本科生职工：");
                Console.WriteLine("工作年数：" + ue.getTime());
                Console.WriteLine("该本科生职工工资：" + ue.getSalary());
                Console.ReadKey();
            

            //MyDel mydel = new MyDel(squareSum);
            //mydel += squareSub;

            //mydel(4, 3);

            //Console.ReadKey()
        }
    }
}

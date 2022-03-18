using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        //定义委托 (类似于函数指针)
        public delegate void Mydel(string name);
        public delegate void Mydel2(int a, int b);

        static void Main(string[] args)
        {
            ////定义委托变量
            //Mydel mydel = new Mydel(cGreet);  
            //Mydel mydel2;

            //Program p = new Program();
            //mydel2 = p.eGreet;
            //mydel2 += cGreet;  //此时mydel2 有两个方法

            //mydel2("张三");

            Mydel2 mydel = new Mydel2(Sum);
            mydel += Subtract;

            mydel(100, 90);

            Console.ReadKey();
        }

        public static void cGreet(string name)
        {
            Console.WriteLine(name+" 您好！");
        }

        public void eGreet(string name)
        {
            Console.WriteLine(name + " Hello！");
        }

        public static void Sum(int a,int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a + " - " + b + " = " + (a - b));
        }
    }
}

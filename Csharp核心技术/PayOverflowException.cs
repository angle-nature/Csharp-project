using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp核心技术
{
    class PayOverflowException:Exception
    {
        //定义字段
        string excode;    //错误代码
        string exmessage; //错误信息

        public string Excode { get => excode; set => excode = value; }
        public string Exmessage { get => exmessage; set => exmessage = value; }

        //重构父类的构造函数
        public PayOverflowException(string message):base(message)
        {
            this.Exmessage = message;
        }
    }

    class Employee
    {
        string name;
        int currpay;

        public string Name { get => name; set => name = value; }
        public int Currpay { get => currpay; set => currpay = value; }

        public Employee(string name,int currpay)
        {
            this.Name = name;
            this.Currpay = currpay;
        }

        public int giveBunus(int amount)
        {
            int pay = Currpay;
            this.Currpay = this.Currpay + amount;

            if(Currpay>10000)
            {
                this.Currpay = pay;
                PayOverflowException pe = new PayOverflowException("员工的工资不应该超过10000!");
                throw pe;
            }

            return this.Currpay;
        }
    }

    class test01
    {
        static void Main(string[] args)
        {
            int currypay = 9000;
            Employee m = new Employee("张三", currypay);

            try
            {
                int amount;
               
                Console.WriteLine("当前工资为：" + currypay);
                Console.WriteLine("请输入奖金：");
                amount = int.Parse(Console.ReadLine());
                Console.WriteLine("加入奖金后工资：");
                Console.WriteLine(m.giveBunus(amount));
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            catch(PayOverflowException pe)
            {
                Console.WriteLine(pe.Message);
            }

            Console.ReadKey();

        }
    }

}

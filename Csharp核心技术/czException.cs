using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp核心技术
{
    //自定义异常类 继承exception
    class czException:Exception
    {
        //定义字段
        string excode;    //错误代码
        string exmessage; //错误信息

        public string Excode { get => excode; set => excode = value; }
        public string Exmessage { get => exmessage; set => exmessage = value; }

        //重构父类的构造函数
        public czException(string message)
        {
            this.Exmessage = message;
        }

        public czException(string code,string message):base(message)
        {
            this.Exmessage = message;
            this.Excode = code;
        }  
    }

    class Person
    {
        public static int testPerson()
        {
            int n;
            Console.WriteLine("请输入汽车的人数：");
            n = int.Parse(Console.ReadLine());

            //超过无人就是超载
            if (n > 5)
            {
                czException ce = new czException("110", " 超载了！");
                throw ce; //抛出异常
            }


            return n;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {

            try
            {
                int n = Person.testPerson();
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (czException ce)
            {
                Console.WriteLine(ce.Message);
            }
        }
    }
}

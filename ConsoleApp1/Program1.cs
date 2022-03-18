using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            //接口不能实例化
            Mq m1 = new Mq();
            IFly m2 = new Mq();
            m1.fly();

            IFly f1 = create("mq");
            f1.fly();
            IFly f2 = create("yw");
            f2.fly();
            

            Console.ReadKey();
        }

        //简单的工厂模式
        static IFly create(string bird)
        {
            IFly f1 = null;
            switch(bird)
            {
                case "mq":
                    f1 = new Mq();
                    break;
                case "yw":
                    f1 = new Yingwu();
                    break;
                default:
                    break;
            }

            return f1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //interface 接口
    interface IFly
    {
        //方法  接口里的成员不能有修饰符  方法不能有实现
        void fly();
    }

    interface ISpeak
    {
        void speak();
    }

    class Bird
    {
        private string name;

        public string Name { get => name; set => name = value; }
    }

    class Mq : Bird, IFly
    {
        public void fly()
        {
            Console.WriteLine("翱翔！");
        }
    }

    class Yingwu:Bird,IFly,ISpeak
    {
        public void fly()
        {
            Console.WriteLine("翱翔！");
        }

        void ISpeak.speak()
        {
            Console.WriteLine("hello!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat
    {
        //字符  成员变量
        public string name;
        public int age;

        public string Name
        {
            get { return Name; }
            set { name = Name; }
        }

        public int Age
        {
            get { return Age; }
            set 
            {
                if (Age > 0 && Age <= 20)
                    age = Age;
                else
                    Console.WriteLine("非法数据！");
            }
        }

        //定义方法
        public void sayHi()
        {
            Console.WriteLine("hi 我是{0}", name);
        }

        //默认构造函数（无参构造函数）
        public Cat() { }

        //有参构造  写了有参构造函数之后 系统提供的默认构造函数将不存在
        public Cat(string Name)
        {
            this.name = Name;
            //this.age = Age;
        }

        //析构函数
        ~Cat()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    //定义委托 相当于一个监视
    public delegate void Mydel(string name);

    //学生类 - 发生事件   事件发布者
    class Student
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public Student(string name)
        {
            this.Name = name;
        }

        //定义一个事件 event
        public event Mydel GameEvent;  //event 事件由 Mydel 委托
        //方法
        public void PlayGame()
        {
            Console.WriteLine(this.Name+"玩游戏中-------");
            //触发事件
            if(GameEvent!=null)
            {
                GameEvent(this.Name);  //触发玩游戏事件
            }
        }
    }

    //教师类 - 处理事件   事件订阅者
    class Teacher
    {
        //定义事件处理程序-方法
        public void Dosomething(string name)
        {
            Console.WriteLine(name+ "不要玩游戏了! 好好学习！");
        }
    }

    //事件订阅者
    class Fudaoyaun
    {
        //定义事件处理程序-方法
        public void Dosomething(string name)
        {
            Console.WriteLine(name + "到我办公室来一趟！");
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("张三");
            Teacher t1 = new Teacher();
            Fudaoyaun fdy1 = new Fudaoyaun();
            //给事件绑定方法
            std1.GameEvent += new Mydel(t1.Dosomething);
            std1.GameEvent += fdy1.Dosomething;

            std1.PlayGame();

            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工大租车管理系统
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mu = new Menu();  //new 一个菜单对象
            mu.showMenu1(); //调用菜单界面

            int select1;
            select1 = Convert.ToInt32(Console.ReadLine());

            if (select1 == 1)
            {
                String select2;
                while (true)
                {
                    Console.Clear(); //清屏
                    mu.showMenu2(); //调用车辆类型及其价目表
                    Console.WriteLine("请选择你要租用的车辆类型或打印账单：");                  
                    select2 = Console.ReadLine();

                    switch (select2)
                    {
                        case "1":
                            {
                                Car c = new AodiA4(); 
                                mu.sum(c, 0); //计算该种车型的载客量、载货量及租金
                            }

                            break;
                        case "2":
                            {
                                Car c = new Mazida6();
                                mu.sum(c, 1);
                            }
                            break;
                        case "3":
                            {
                                Car c = new Pikaxue6();
                                mu.sum(c, 2);
                            }
                            break;
                        case "4":
                            {
                                Car c = new Jinlong();
                                mu.sum(c, 3);
                            }
                            break;
                        case "5":
                            {
                                Car c = new Songhuajiang();
                                mu.sum(c, 4);
                            }
                            break;
                        case "6":
                            {
                                Car c = new Yiweike();
                                mu.sum(c, 5);
                            }
                            break;
                        case "0":
                            Console.Clear(); //清屏
                            mu.showMenu2();
                            mu.showBill(); //展示账单
                            Console.WriteLine("欢迎下次使用");
                            Console.ReadKey();
                            System.Environment.Exit(0); //退出系统
                            break;
                        default:
                            Console.WriteLine("输入有误,请重新输入!");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("欢迎下次使用");
                Console.ReadKey();
            }
        }
    }
}

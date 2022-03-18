using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工大租车管理系统
{
    class Menu
    {
        //欢迎界面
        public void showMenu1()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("       欢迎使用工大租车系统");
            Console.WriteLine("       您是否要使用租车系统：\n            1 是，0 否");
            Console.WriteLine("====================================");
        }

        //菜单
        public void showMenu2()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("          您可租车的类型及其价目表：");
            Console.WriteLine("序号\t汽车名称\t租金（元/天）\t容量");
            Console.WriteLine("1.\t奥迪A4\t\t500\t\t载人：4人");
            Console.WriteLine("2.\t马自达6\t\t400\t\t载人：4人");
            Console.WriteLine("3.\t皮卡雪6\t\t450\t\t载人：4人，载货：2吨");
            Console.WriteLine("4.\t金龙\t\t800\t\t载人：20人");
            Console.WriteLine("5.\t松花江\t\t400\t\t载货：4吨");
            Console.WriteLine("6.\t依维柯\t\t1000\t\t载货：20吨");
            Console.WriteLine("0.\t打印账单");
            Console.WriteLine("==============================================================");
        }

        private int capacitySum = 0; //总载客量
        private float loadSum = 0; //总载货量
        private float fareSum = 0; //总租金

        private int[] number = new int[6] { 0, 0, 0, 0, 0, 0 };  //存放每种车辆的数目
        private int[] days = new int[6] { 0, 0, 0, 0, 0, 0 };  //存放每种车辆的天数

        public int CapacitySum { get => capacitySum; set => capacitySum = value; }
        public float LoadSum { get => loadSum; set => loadSum = value; }
        public float FareSum { get => fareSum; set => fareSum = value; }

        public void sum(Car c,int i)
        {
            int n, day;
            Console.WriteLine("请输入租用该汽车的数量");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入租用该汽车的天数");
            day = Convert.ToInt32(Console.ReadLine());
            CapacitySum += c.CapacitySum(n);  //计算总的载客量
            LoadSum += c.LoadSum(n);  //计算总的载货量
            FareSum += c.Rent(n,day);  //计算总的租金
            number[i] += n; //每种类型的车的数量
            days[i] += day; //每种类型的车的所租天数
        }

        //打印账单
        public void showBill()
        {
            string[] name = { "奥迪A4", "马自达6", "皮卡雪6", "金龙", "松花江", "依维柯" };

            Console.WriteLine("您的账单：\n");
            Console.WriteLine("车辆名称\t数量\t天数");

            for(int i=0;i<6;i++)            
                if(number[i]!=0)               
                    Console.WriteLine(name[i] + "\t\t" + number[i]+"\t"+days[i]);                  

            Console.WriteLine("-----------------------------");
            Console.Write("共载人：" + capacitySum + "人\t");
            Console.WriteLine("共载货：" + String.Format("{0:F1}", loadSum)+ "吨");
            Console.WriteLine("租车总金额：" + String.Format("{0:F1}", fareSum)); 
            //String.Format("{0:F1}", fareSum)) 保留一位小数
        }
    }
}

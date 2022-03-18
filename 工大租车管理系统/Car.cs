using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工大租车管理系统
{
    abstract class Car
    {
        private string name;  //车名称
        private float fare; //租车价格  元/天
        private int capacity; //载客量
        private float load;  //载重量  /t

        public string Name { get => name; set => name = value; }
        public float Fare { get => fare; set => fare = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public float Load { get => load; set => load = value; }

        //计算单种车型的载客量
        public int CapacitySum(int n)
        {
            return n * capacity;
        }

        //计算单种车型的载货量
        public float LoadSum(int n)
        {
            return n * load;
        }

        //计算单种车型的租金
        public float Rent(int n,int days)
        {
            return n * days * fare;
        }

    }

    //奥迪A4
    class AodiA4:Car
    {
        public AodiA4()
        {
            this.Name = "奥迪A4";
            this.Fare = 500;
            this.Capacity = 4;
            this.Load = 0;
        }
    }

    //马自达6
    class Mazida6:Car
    {
        public Mazida6()
        {
            this.Name = "马自达6";
            this.Fare = 400;
            this.Capacity = 4;
            this.Load = 0;
        }
    }

    //金龙
    class Jinlong : Car
    {
        public Jinlong()
        {
            this.Name = "金龙";
            this.Fare = 800;
            this.Capacity = 20;
            this.Load = 0;
        }
    }

    //皮卡雪6
    class Pikaxue6:Car
    {
        public Pikaxue6()
        {
            this.Name = "皮卡雪6";
            this.Fare = 450;
            this.Capacity = 4;
            this.Load = 2;
        }
    }

    //松花江
    class Songhuajiang:Car
    {
        public Songhuajiang()
        {
            this.Name = "松花江";
            this.Fare = 400;
            this.Capacity = 0;
            this.Load = 4;
        }
    }

    //依维柯
    class Yiweike : Car
    {
        public Yiweike()
        {
            this.Name = "依维柯";
            this.Fare = 1000;
            this.Capacity = 0;
            this.Load = 20;
        }
    }
}

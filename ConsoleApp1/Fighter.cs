using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //抽象类  不允许实列化
    abstract class Fighter
    {
        private string name; //姓名
        private int hp;  //体力值
        private int power;  //武力值
        private int iq; //智力值

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Power { get => power; set => power = value; }
        public int Iq { get => iq; set => iq = value; }

        //有参构造
        public Fighter(string name,int hp,int power,int iq)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.iq = iq;
        }

        //无参构造(默认构造)
        public Fighter() : this("武士甲", 100, 60, 90)
        {

        }

        //虚方法
        //public virtual void attack(Fighter f)
        //{
        //    Console.WriteLine(this.name+"使用火攻攻击了"+f.name);
        //}

        //抽象方法
        public abstract void attack(Fighter f);


    }
    
    //武力型武士
    class BullFighter:Fighter
    {
        public BullFighter(string name) : base(name, 100, 100, 60) { }   

        //override 重写抽象方法
        public override void attack(Fighter f)
        {
            //base.attack(f);
            Console.WriteLine(this.Name + "使用了火攻攻击了" + f.Name);
        }
    }

    //智力型谋士
    class IqFighter : Fighter
    {
        public IqFighter(string name) : base(name, 60, 60, 100) { }

        public override void attack(Fighter f)
        {

            Console.WriteLine(this.Name + "使用了调虎离山攻击了" + f.Name);
        }
    }
}

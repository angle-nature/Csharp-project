using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Play
    {
        static void Main(string[] args)
        {
            BullFighter f1= new BullFighter("张飞");
            showFg(f1);
            Console.WriteLine("=====================");
            IqFighter f2=new IqFighter("司马懿");
            showFg(f2);
            Console.WriteLine("=====================");
            BullFighter f3 = new BullFighter("吕布");
            showFg(f3);
            Console.WriteLine("=====================");
            IqFighter f4 = new IqFighter("诸葛亮");
            showFg(f4);
            Console.WriteLine("=====================");
            f1.attack(f2);
            f4.attack(f3);

            Console.WriteLine("=========组团==========");
            Fighter []fg = new Fighter[] { f1, f2, f3, f4 };

            for(int i=0;i<fg.Length;i++)
            {
                if (i < fg.Length - 1)
                    fg[i].attack(fg[i + 1]);
                else
                    fg[i].attack(fg[0]);
            }

            Console.ReadKey();
        }

        static void showFg(Fighter f)
        {
            Console.WriteLine("武士姓名：" + f.Name);
            Console.WriteLine("武士体力值：" + f.Hp);
            Console.WriteLine("武士武力值：" + f.Power);
            Console.WriteLine("武士智力值：" + f.Iq);

        }
    }
}

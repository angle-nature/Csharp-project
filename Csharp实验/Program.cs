using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp实验
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1 2 3 4 5 6 7 8 9";
            string[] strArr = str.Split(' ');         
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            foreach(string s in strArr)
            {
                if (Convert.ToInt32(s) % 2 != 0)
                    list1.Add(s);
                else
                    list2.Add(s);
            }

            list1.AddRange(list2);

            foreach(string s in list1)
            {
                Console.Write(s+" ");
            }
            Console.ReadKey();
        }
    }
}

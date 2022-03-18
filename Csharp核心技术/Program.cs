using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp核心技术
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = "aaa   bbb";

            string[] strArr = str.Split(new char[] { ' '},4);

            Console.WriteLine(strArr.Length);

            for(int i=0;i<strArr.Length;i++)
            {
                Console.WriteLine(strArr[3]);
            }

            str = String.Join("-", strArr);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}

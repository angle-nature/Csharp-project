using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp实验
{
    class StudentScore
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            FileStream fs = File.OpenRead(@"E:\C#项目\Csharp实验\Score.txt");
            StreamReader sr = new StreamReader(fs);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                list1.Add(str);
            }

            sr.Close();
            fs.Close();

            string[] strArr = new string[2];

            foreach (string s in list1)
            {
                strArr = s.Split('|');
                strArr[1] = (Convert.ToInt32(strArr[1]) + 20).ToString();
                list2.Add(strArr[0] + "|" + strArr[1]);
            }

            FileStream fs1 = File.OpenWrite(@"E:\C#项目\Csharp实验\ScoreNew.txt");
            StreamWriter sw = new StreamWriter(fs1);

            foreach(string s in list2)
            {
                Console.WriteLine(s);
                sw.WriteLine(s);
            }

            sw.Close();
            fs1.Close();

            Console.ReadKey();
        }

    }
}

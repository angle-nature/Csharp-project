using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] s = { "床前明月光", "疑似地上霜", "举头望明月", "低头思故乡" };
            //File.WriteAllLines(@"E:\C#项目\\FileStudy\静夜思.txt", s);
            /*
                        //文件流
                        FileStream fs = new FileStream(@"E:\C#项目\\FileStudy\ababa.txt",FileMode.Create);
                        //写入器
                        StreamWriter sw = new StreamWriter(fs);
                        //sw.Write("床前明月光");

                        List<String> list = new List<String> { "我和我的家乡", "八佰", "七号房的礼物" };

                        foreach(String item in list)
                        {
                            sw.WriteLine(item);
                        }


                        sw.Close();  //先关写入器
                        fs.Close();  //后关文件流
            */

            FileStream fs1 = File.OpenRead(@"E:\C#项目\\FileStudy\ababa.txt");
            StreamReader sr = new StreamReader(fs1);

            string str;

            while ((str=sr.ReadLine())!=null)
            {
                Console.WriteLine(str);
            }

            sr.Close();
            fs1.Close();

            Console.ReadKey();
        }
    }
}

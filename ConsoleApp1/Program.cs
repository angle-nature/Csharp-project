using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int.Parse() 强制转换为32位的int类型
//Convert.ToInt32(); 转换函数

//Console.WriteLine(sum); //输出
//Console.WriteLine("姓名：{0} 年龄：{1}", 1, 2); //{0}、{1}：占位符

//ref 修饰符 引用符号 相当于c++中的 &

//类中的成员变量有初始值 数据类型为0  字符类型为空串 布尔类型为 false

namespace ConsoleApp1 
{
    class Program
    {
        static void Main(string[] args)
        {
            string input="yes";
            while ("yes".Equals(input.ToLower()))
            {
                Console.WriteLine("请输入你的邮箱：");
                string email = Console.ReadLine();
                Console.WriteLine("你的邮箱是" + email);

                string name;
                name = email.Substring(0, email.IndexOf('@'));
                Console.WriteLine("你的用户名是：" + name);

                Console.WriteLine("是否继续输入邮箱  yes， no");
                input = Console.ReadLine();

            }
            Console.ReadKey();  


        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Csharp核心技术
{
    class Test
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("aaa", 20);
            Student s2 = new Student("bbb", 21);
            Student s3 = new Student("ccc", 22);
            Student s4 = new Student("ddd", 23);

            ArrayList a1 = new ArrayList();

            a1.Add(s1); 
            a1.Add(s2);
            a1.Add(s3);
            a1.Add(s4);
            //a1.Add(2); //可以添加不同类型的值

            foreach(object item in a1)
            {
                if(item is Student)
                {
                    Student sd = (Student)item;
                    Console.WriteLine(sd.Name + " " + sd.Age);
                }
            }

            Random r = new Random();

            ArrayList a2 = new ArrayList();

            int i = 0, temp;
            while (i<10)
            {
                temp = r.Next(1, 101);
                if(temp%2==0)
                {
                    a2.Add(temp);
                    i++;
                }
            }

            foreach (object item in a2)
            {
                Console.WriteLine((int)item);
            }

            Console.ReadKey();
        }
    }
}

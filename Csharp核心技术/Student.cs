using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp核心技术
{
    class Student
    {
        string m_name;
        int m_age;

        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;         
        }

        public string Name { get => m_name; set => m_name = value; }
        public int Age { get => m_age; set => m_age = value; }
    }
}

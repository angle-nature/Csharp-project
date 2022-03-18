using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        private string name;
        private string ID;
        private double baseSalary=1000;
        private double salary;
        private int time;

        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Time { get => time; set => time = value; }

        public void setTime(int t)
        {
            this.Time = t;
        }

        public int getTime()
        {
            return this.Time;
        }

        public virtual double getSalary()
        {
            return BaseSalary + Time * 30;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheretance
{
    class Developer:Person
    {
        public double Salary;

        public Developer(string name,string surname,int age,double salary):base(name,surname,age)
        {
            Salary = salary;
        }

        public override string Info()
        {
            return $"{base.Info()} {Salary}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheretance
{
    //Inheretance!!!
    class Student:Person
    {
        public double Payment;

        //constructor - method - return type olmayan metoddur - ayriliqda chagrila bilmir,
        //yalniz obyekt instance alinanda ishe dushur - class adi ile eyni adda metoddur
        public Student()
        {
            Console.WriteLine("Student created");
        }

        public Student(string name, string surname):this()
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name,string surname,int age):this(name,surname)
        {
            Age = age;
        }
        public override string Info()
        {
            return $"{base.Info()} {Payment}";
        }
    }
}

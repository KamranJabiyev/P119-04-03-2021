﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheretance
{
    partial class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public Person()
        {
        }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Console.WriteLine("Person created");
        }
    }

    
}

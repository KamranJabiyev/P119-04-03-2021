using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheretance
{
    partial class Person
    {
        public string Fullname()
        {
            return $"{Name} {Surname}";
        }

        //polymorphism !!!
        public virtual string Info()
        {
            return $"{Fullname()} {Age}";
        }
    }
}

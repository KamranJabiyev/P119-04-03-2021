using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheretance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class,anonimous object
            //string name = "Ferid";
            //string surname = "Memmedov";
            //int age = 22;

            //string name1 = "Orxan";
            //string surname1 = "Abdullayev";
            //int age1 = 24;

            //var stu1 = new
            //{
            //     name = "Ferid",
            //     surname = "Memmedov",
            //     age = 22,
            //     payment=4000
            //};

            //var stu2 = new
            //{
            //    name = "Orxan",
            //    surname = "Abdullayev",
            //    age = 24,
            //    payment=3200
            //};

            //Console.WriteLine(stu1.name);
            //Console.WriteLine(stu2.name);

            //instance
            Student s1 = new Student("Ferid", "Memmedov", 22);
            Console.WriteLine(s1.Info());

            Developer d1 = new Developer("Kamran","Jabiyev",30,100);
            Console.WriteLine(d1.Info());
            //Student s2 = new Student("Orxan", "Abdullayev", 24);
            //Console.WriteLine(s2.Info());
            //Student s3 = new Student();
            #endregion
        }
    }
}

using Access_modifiers_2.Models;
using System;

namespace Access_modifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1.Name = "Turan";
            Console.WriteLine(stu1.Name);
            stu1.Surname = "Abdullayev";
            Console.WriteLine(stu1.Surname);
            stu1.point = 50;
            Console.WriteLine(stu1.point);
        }
    }
}

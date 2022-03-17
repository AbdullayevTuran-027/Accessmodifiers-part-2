using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers_2.Models
{
    internal class Student:Person
    {
        private double Point;

        public double point
        {
            get 
            {
                return Point;
            }  
            set
            {
               if (value >= 0 && value <= 100)
                    Point = value;
               else
                    Console.WriteLine("minumum 0 maxsimum 100 ola biler");
                
            } 
        }
        public Student(double Point)
        {
            this.Point = Point;

        }

        public Student()
        {
        }
    }
}

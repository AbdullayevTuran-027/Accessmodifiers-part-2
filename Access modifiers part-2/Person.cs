using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers_2.Models
{
    internal class Person
    {
        private string name;
        private int age;
        private string surname;

        public string Name 
        { 
            get
            { 
                return name;
            }
            set
            { 
                if (value.Length >= 3 && value.Length <= 30)
                {
                    name = value;
                    Console.WriteLine(UpperLetter(name));
                }
                if(UpperLetter(name) == false)
                {
                    Console.WriteLine("Ad boyuk herifle bawdiyir");
                }
                else
                {
                    Console.WriteLine("name minimum 3 maxsimum 30 herifden ibaret ola biler");
                }
            }
        }
        public string Surname 
        {
            get 
            {
                return surname;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 35)
                {
                    surname = value;
                    Console.WriteLine(UpperLetter(surname));
                }
                if (UpperLetter(surname) == false)
                {
                    Console.WriteLine("surname boyuk herifle bawdiyir");
                }
                else
                {
                    Console.WriteLine("surname minimum 3 maxsimum 35 herifden ibaret ola biler");
                }
            }
        }

        public Person()
        {

        }

        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }

        private bool UpperLetter(string Name)
        {
            foreach (char upper in Name)
            {
                if (char.IsUpper(upper))
                    return true;
            }
            return false;
        }
    } 
}

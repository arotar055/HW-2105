using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Person
    {
        protected string name;    
        protected string surname;
        protected string phone;
        protected int age;

        public Person() 
        { 
            name = "";
            surname = "";
            phone = "";
            age = 0;
        }
        public Person(string n, string s, string p, int a) 
        {
            name = n;
            surname = s;
            phone = p;
            age = a;
        }

        public string Name {  
            get { return name; } 
            set { name = value; } 
        }

        public string Surname
        { 
            get { return surname; } 
            set { surname = value; } 
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int Age { 
            get { return age; } 
            set { age = value; } 
        }

        public void Print() 
        {
            Console.WriteLine("Имя - " + name + "\nSurname - " + surname + "\nPhone - " + phone + "\nAge - " + age);    
        }

    }
}

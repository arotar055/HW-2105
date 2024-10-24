using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Student : Person
    {
        double average;
        int number_of_group;

        public double Average 
        { 
            get { return average; }
            set { average = value; }
        }

        public int NumberOfGroup 
        { 
            get { return number_of_group;}
            set { number_of_group = value; }    
        }

        public Student() : base() 
        {
            average = 0.0;
            number_of_group = 0;
        }

        public Student(string value_name, string value_surname,  int value_age, string value_phone, double value_Average, int value_number_of_group) 
        { 
            name = value_name;
            surname = value_surname;
            age = value_age;
            phone = value_phone;
            average = value_Average;
            number_of_group = value_number_of_group;    
        }

        public void Print()     
        {
            base.Print();   
            Console.WriteLine("Average - " + average + "\nNumber of group - " + number_of_group); 
        }
    }
}

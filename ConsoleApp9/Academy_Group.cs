using System;
using System.Collections;
using System.IO;

namespace ConsoleApp9
{
    class Academy_Group
    {
        ArrayList students;
        int count;

        public Academy_Group()
        {
            students = new ArrayList();
            count = 0;
        }

        // Method to add a student to the group
        public void Add(Student student)
        {
            students.Add(student);
            count++;
            Console.WriteLine("Student " + student.Name + " " + student.Surname + " has been added.");
        }

        // Method to remove a student from the group
        public void Remove(string student_surname)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = (Student)students[i];
                if (student.Surname.Equals(student_surname, StringComparison.OrdinalIgnoreCase))
                {
                    students.RemoveAt(i);
                    count--;
                    Console.WriteLine("Student " + student_surname + " has been removed from the group.");
                    return;
                }
            }
            Console.WriteLine("Student " + student_surname + " not found in the group.");
        }

        // Method to edit a student
        public void Edit(string student_surname, Student newStudent)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = (Student)students[i];
                if (student.Surname.Equals(student_surname, StringComparison.OrdinalIgnoreCase))
                {
                    students[i] = newStudent;
                    Console.WriteLine("Student " + student_surname + " has been edited to " + newStudent.Surname);
                    return;
                }
            }
        }

        // Print the entire group
        public void Print()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = (Student)students[i];
                Console.WriteLine("\n");
                student.Print();
            }
        }

        // Save group data to a file
        public void Save()
        {
            using (StreamWriter writer = new StreamWriter("Group.txt", false))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Student student = (Student)students[i];
                    string line = "Name - " + student.Name + "\nSurname - " + student.Surname + "\nPhone - " + student.Phone + "\nAge - " + student.Age + "\nAverage - " + student.Average + "\nGroup number - " + student.NumberOfGroup;

                    writer.WriteLine(line);
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Student data has been saved to the file.");
        }

        // Load group data from a file
        public void Load()
        {
            students.Clear();
            count = 0;

            using (StreamReader reader = new StreamReader("Group.txt"))
            {
                string nameLine;
                while ((nameLine = reader.ReadLine()) != null)
                {
                    string surnameLine = reader.ReadLine();
                    string phoneLine = reader.ReadLine();
                    string ageLine = reader.ReadLine();
                    string averageLine = reader.ReadLine();
                    string groupLine = reader.ReadLine();

                    reader.ReadLine();  // Skip the empty line

                    string name = nameLine.Split('-')[1].Trim();
                    string surname = surnameLine.Split('-')[1].Trim();
                    string phone = phoneLine.Split('-')[1].Trim();
                    int age = int.Parse(ageLine.Split('-')[1].Trim());
                    double average = double.Parse(averageLine.Split('-')[1].Trim());
                    int groupNumber = int.Parse(groupLine.Split('-')[1].Trim());

                    Student student = new Student(name, surname, age, phone, average, groupNumber);
                    students.Add(student);
                    count++;
                }
            }

            Console.WriteLine("Student data has been loaded from the file.");
        }

        // Method to search students by the specified criterion
        public void Search(int criterionNumber)
        {
            bool found = false;
            switch (criterionNumber)
            {
                case 1:
                    Console.Write("Enter name to search: ");
                    string searchName = Console.ReadLine();
                    foreach (Student student in students)
                    {
                        if (student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Student found:");
                            student.Print();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 2:
                    Console.Write("Enter surname to search: ");
                    string searchSurname = Console.ReadLine();
                    foreach (Student student in students)
                    {
                        if (student.Surname.Equals(searchSurname, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Student found:");
                            student.Print();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 3:
                    Console.Write("Enter phone to search: ");
                    string searchPhone = Console.ReadLine();
                    foreach (Student student in students)
                    {
                        if (student.Phone.Equals(searchPhone, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Student found:");
                            student.Print();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter age to search: ");
                    string searchAge = Console.ReadLine();
                    foreach (Student student in students)
                    {
                        if (student.Age.ToString().Equals(searchAge))
                        {
                            Console.WriteLine("Student found:");
                            student.Print();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 5:
                    Console.Write("Enter average grade to search: ");
                    string searchAverage = Console.ReadLine();
                    foreach (Student student in students)
                    {
                        if (student.Average.ToString().Equals(searchAverage))
                        {
                            Console.WriteLine("Student found:");
                            student.Print();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 6:
                    Console.Write("Enter group number to search: ");
                    string searchGroupNumber = Console.ReadLine();
                    foreach (Student student in students)
                    {
                        if (student.NumberOfGroup.ToString().Equals(searchGroupNumber))
                        {
                            Console.WriteLine("Student found:");
                            student.Print();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid search criterion.");
                    break;
            }
        }
    }
}


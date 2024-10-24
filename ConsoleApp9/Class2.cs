using System;

namespace ConsoleApp9
{
    class ClassMenu
    {
        Academy_Group academyGroup = new Academy_Group();
        bool running = true;

        public void Menu()
        {
            while (running)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Remove student");
                Console.WriteLine("3. Edit student");
                Console.WriteLine("4. Show group");
                Console.WriteLine("5. Save data");
                Console.WriteLine("6. Load data");
                Console.WriteLine("7. Search student");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        string phone = Console.ReadLine();
                        Console.Write("Enter age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter average grade: ");
                        double average = double.Parse(Console.ReadLine());
                        Console.Write("Enter group number: ");
                        int numberOfGroup = int.Parse(Console.ReadLine());

                        Student student = new Student(name, surname, age, phone, average, numberOfGroup);
                        academyGroup.Add(student);
                        break;

                    case "2":
                        Console.Write("Enter student's surname to remove: ");
                        string removeSurname = Console.ReadLine();
                        academyGroup.Remove(removeSurname);
                        break;

                    case "3":
                        Console.Write("Enter student's surname to edit: ");
                        string editSurname = Console.ReadLine();

                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new surname: ");
                        string newSurname = Console.ReadLine();
                        Console.Write("Enter new phone: ");
                        string newPhone = Console.ReadLine();
                        Console.Write("Enter new age: ");
                        int newAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter new average grade: ");
                        double newAverage = double.Parse(Console.ReadLine());
                        Console.Write("Enter new group number: ");
                        int newNumberOfGroup = int.Parse(Console.ReadLine());

                        Student newStudent = new Student(newName, newSurname, newAge, newPhone, newAverage, newNumberOfGroup);
                        academyGroup.Edit(editSurname, newStudent);
                        break;

                    case "4":
                        academyGroup.Print();
                        break;

                    case "5":
                        academyGroup.Save();
                        break;

                    case "6":
                        academyGroup.Load();
                        break;

                    case "7":
                        Console.WriteLine("Choose search criteria:");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Surname");
                        Console.WriteLine("3. Phone");
                        Console.WriteLine("4. Age");
                        Console.WriteLine("5. Average grade");
                        Console.WriteLine("6. Group number");
                        Console.Write("Your choice: ");

                        int searchCriterion = int.Parse(Console.ReadLine());
                        academyGroup.Search(searchCriterion);
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}


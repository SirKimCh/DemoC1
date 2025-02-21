using Demo2.Model;
using Demo2.Service;
using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            MajorService majorService = new MajorService();
            bool exit = false;

            Console.WriteLine("Welcome to Student Manager");
            Console.WriteLine("1. Student Manager");
            Console.WriteLine("2. Major Manager");
            Console.Write("Enter your choice: ");
            int mainChoice = Validation.MyLib.GetIntInput("Only chose form 1 to 2",1,2);

            while (!exit)
            {
                if (mainChoice == 1)
                {
                    Console.WriteLine("Student Manager Menu:");
                    Console.WriteLine("1. List all Students");
                    Console.WriteLine("2. Add new Student");
                    Console.WriteLine("3. Delete Student by ID");
                    Console.WriteLine("4. Edit Student by ID");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Validation.MyLib.GetIntInput("Only chose form 0 to 4", 0, 4);

                    switch (choice)
                    {
                        case 1:
                            studentService.PrintAllStudents();
                            break;
                        case 2:
                            Console.Write("Enter Name: ");
                            string name = Validation.MyLib.GetStringInput("Name must be have more " +
                                "than one word and not null");
                            Console.Write("Enter Age: ");
                            int age = Validation.MyLib.GetIntInput("Age must be between 17 and 30", 17, 30);
                            studentService.AddStudent(name, age);
                            break;
                        case 3:
                            Console.Write("Enter ID of the student to delete: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            Student? studentToDelete = studentService.FindStudentById(deleteId);
                            if (studentToDelete != null)
                            {
                                studentService.RemoveStudent(studentToDelete);
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter ID of the student to edit: ");
                            int editId = int.Parse(Console.ReadLine());
                            if (studentService.FindStudentById(editId) == null)
                            {
                                Console.WriteLine("Student not found.");
                                break;
                            }
                            Console.Write("Enter new Name: ");
                            string newName = Validation.MyLib.GetStringInput("Name must be have more " +
                                "than one word and not null");
                            Console.Write("Enter new Age: ");
                            int newAge = Validation.MyLib.GetIntInput("Age must be between 17 and 30", 17, 30);
                            studentService.EditStudent(editId, newName, newAge);
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else if (mainChoice == 2)
                {
                    Console.WriteLine("Major Manager Menu:");
                    Console.WriteLine("1. List all Majors");
                    Console.WriteLine("2. Add new Major");
                    Console.WriteLine("3. Delete Major by ID");
                    Console.WriteLine("4. Edit Major by ID");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Validation.MyLib.GetIntInput("Only chose form 0 to 4", 0, 4);

                    switch (choice)
                    {
                        case 1:
                            majorService.PrintAllMajors();
                            break;
                        case 2:
                            Console.Write("Enter Name: ");
                            string name = Validation.MyLib.GetStringInput("Name must be have more " +
                                "than one word and not null");
                            majorService.AddMajor(name);
                            break;
                        case 3:
                            Console.Write("Enter ID of the major to delete: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            Major? majorToDelete = majorService.FindMajorById(deleteId);
                            if (majorToDelete != null)
                            {
                                majorService.RemoveMajor(majorToDelete);
                            }
                            else
                            {
                                Console.WriteLine("Major not found.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter ID of the major to edit: ");
                            int editId = int.Parse(Console.ReadLine());
                            if (majorService.FindMajorById(editId) == null)
                            {
                                Console.WriteLine("Major not found.");
                                break;
                            }
                            Console.Write("Enter new Name: ");
                            string newName = Validation.MyLib.GetStringInput("Name must be have more " +
                                "than one word and not null");
                            majorService.EditMajor(editId, newName);
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.Write("Enter your choice: ");
                    mainChoice = Validation.MyLib.GetIntInput("Only chose form 1 to 2", 1, 2);
                }
                Console.WriteLine();
            }
        }
    }
}

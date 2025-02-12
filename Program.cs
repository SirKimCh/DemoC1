using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            bool exit = false;
            studentService.AddStudent("Kimchi", 20);
            studentService.AddStudent("Kim", 21);
            studentService.AddStudent("Chi", 22);

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. List all Students");
                Console.WriteLine("2. Add new Student");
                Console.WriteLine("3. Delete Student by ID");
                Console.WriteLine("4. Edit Student by ID");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        studentService.PrintAllStudents();
                        break;
                    case "2":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());
                        studentService.AddStudent(name, age);
                        break;
                    case "3":
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
                    case "4":
                        Console.Write("Enter ID of the student to edit: ");
                        int editId = int.Parse(Console.ReadLine());
                        if (studentService.FindStudentById(editId) == null)
                        {
                            Console.WriteLine("Student not found.");
                            break;
                        }
                        Console.Write("Enter new Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new Age: ");
                        int newAge = int.Parse(Console.ReadLine());
                        studentService.EditStudent(editId, newName, newAge);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

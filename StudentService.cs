using System;
using System.Collections.Generic;

namespace Demo2
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, int age)
        {
            int newId = students.Count > 0 ? students[students.Count - 1].Id + 1 : 1;
            Student newStudent = new Student(newId, name, age);
            students.Add(newStudent);
            Console.WriteLine("Student added successfully.");
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine("Student removed successfully.");
        }

        public void EditStudent(int id, string newName, int newAge)
        {
            Student? student = FindStudentById(id);
            if (student != null)
            {
                student.Name = newName;
                student.Age = newAge;
                Console.WriteLine("Student details updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void PrintAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }

        public Student? FindStudentById(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
    }
}

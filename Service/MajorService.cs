using Demo2.Model;
using System;
using System.Collections.Generic;

namespace Demo2.Service
{
    public class MajorService
    {
        private List<Major> majors = new List<Major>();

        public void AddMajor(string name)
        {
            int newId = majors.Count > 0 ? majors[majors.Count - 1].Id + 1 : 1;
            Major newMajor = new Major(newId, name);
            majors.Add(newMajor);
            Console.WriteLine("Major added successfully.");
        }

        public void RemoveMajor(Major major)
        {
            majors.Remove(major);
            Console.WriteLine("Major removed successfully.");
        }

        public void EditMajor(int id, string newName)
        {
            Major? major = FindMajorById(id);
            if (major != null)
            {
                major.Name = newName;
                Console.WriteLine("Major details updated successfully.");
            }
            else
            {
                Console.WriteLine("Major not found.");
            }
        }

        public void PrintAllMajors()
        {
            foreach (var major in majors)
            {
                Console.WriteLine($"ID: {major.Id}, Name: {major.Name}");
            }
        }

        public Major? FindMajorById(int id)
        {
            foreach (var major in majors)
            {
                if (major.Id == id)
                {
                    return major;
                }
            }
            return null;
        }
    }
}

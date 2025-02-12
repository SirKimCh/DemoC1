using System;

namespace Demo2.Model
{
    public class Major
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Major(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}

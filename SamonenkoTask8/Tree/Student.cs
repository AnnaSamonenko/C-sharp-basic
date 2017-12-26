using System;
using System.Reflection;

namespace Tree
{
    public class Student : IComparable<Student>
    {
        public string Name { get;}
        public double Point { get;}

        public Student(string name, double point)
        {
            Name = name;
            Point = point;
        }

        public int CompareTo(Student other)
        {
            return Point.CompareTo(other.Point);
        }
    }
}
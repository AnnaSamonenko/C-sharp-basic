using System;
using System.Collections.Generic;

namespace Tree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RunStudentTree();
            RunPrimaryTree();
            TryAddNull();
        }

        public static void RunStudentTree()
        {
            Student[] students = {new Student("Anna", 4), new Student("Lera", 5), new Student("Katya", 4.7)};
            BTree<Student> tree = new BTree<Student>(students);
            foreach (Student var in tree)
            {
                Console.WriteLine(var.Name + " " + var.Point);
            }
        }

        public static void RunPrimaryTree()
        {
            BTree<int> treeInt = new BTree<int>();
            treeInt.Add(5);
            treeInt.Add(6);

            foreach (int var in treeInt)
            {
                Console.WriteLine(var);
            }
        }
        
        public static void TryAddNull()
        {
            try
            {
                BTree<Student> tree = new BTree<Student>();
                tree.Add(null);

                foreach (Student var in tree)
                {
                    Console.WriteLine(var);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
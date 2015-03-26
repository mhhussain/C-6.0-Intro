using System;
using System.Console;
using System.Collections.Generic;

namespace CApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                FirstName = "Mohammed",
                LastName = "Hussain"
            };

            var students = new Dictionary<int, Student>();
            students.Add(100, new Student { FirstName = "Batman" });
            students.Add(101, new Student { FirstName = "Superman" });
            students.Add(103, new Student { FirstName = "Pikachu" });

            foreach (var element in students)
            {
                WriteLine(element.Value.FirstName);
            }
        }
    }
}

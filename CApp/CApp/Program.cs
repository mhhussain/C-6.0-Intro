using System;
using System.Console;

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

            WriteLine(student.FullName);
        }
    }
}

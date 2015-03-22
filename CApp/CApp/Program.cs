using System;

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

            Console.WriteLine(student.FullName);
        }
    }
}

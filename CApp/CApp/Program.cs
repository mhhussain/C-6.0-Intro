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

            var failures = 0;

            for (var i = 0; i < 1000; i++)
            {
                try
                {
                    student.GetAllStudents();
                }
                catch (TimeoutException) if (failures++ < 10)
                {
                    WriteLine("You've earned a timeout.");
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
    }
}
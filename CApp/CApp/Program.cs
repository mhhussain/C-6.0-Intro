using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

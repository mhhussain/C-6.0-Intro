using System;
using System.Threading;

namespace CApp
{
    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public int GetAllStudents()
        {
            Thread.Sleep(500);
            throw new TimeoutException("Oh crap the cops, run!!!!");
            return 0;
        }
    }
}

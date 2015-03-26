using System;

namespace CApp
{
    public class Student
    {
        private readonly String _firstName;
        private readonly String _lastName;

        public Student(String firstName, String lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public String FirstName { get; }
        public String LastName { get; }
    }
}

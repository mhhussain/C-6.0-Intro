using System;

namespace CApp
{
    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String FullName => String.Format("{0} {1}", FirstName, LastName);
    }
}

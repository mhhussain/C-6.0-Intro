using System;
using System.Collections.Generic;

namespace CApp
{
    public class School
    {
        public School()
        {
            var teacher = new Teacher
            {
                Name = @"Dr. Fox"
            };

            var course = new Course
            {
                Name = "What the fox really says.",
                Teacher = teacher
            };

            Student = new Student
            {
                FirstName = "Mohammed",
                LastName = "Hussain",
                Course = course
            };
        }

        public Student Student { get; set; }
    }

    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Course Course { get; set; }
    }

    public class Course
    {
        public String Name { get; set; }
        public Teacher Teacher { get; set; }
    }

    public class Teacher
    {
        public String Name { get; set; }
    }
}

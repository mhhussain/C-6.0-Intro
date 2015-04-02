using System;
using System.Console;

namespace CApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();

            if (school != null)
            {
                if (school.Student != null)
                {
                    if (school.Student.Course != null)
                    {
                        if (school.Student.Course.Teacher != null)
                        {
                            WriteLine(school.Student.Course.Teacher.Name);
                        }
                    }
                }
            }
        }
    }
}

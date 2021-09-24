using System;

namespace ThrowExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = null;

            try {

                PrintStudentName(std);
            
            }catch(Exception ex) {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        //create a method to print student name
        public static void PrintStudentName(Student std)
        {
            if(std == null)
            {
                throw new NullReferenceException("Student object is null.");
            }
            Console.WriteLine(std.StudentName);
        }
    }
}

//create a Student Class
public class Student
{
    public string StudentName { get; set; }
}
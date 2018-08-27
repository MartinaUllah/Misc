using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var student = new Student();

            student.Age = 12;
            student.Teacher = new Teacher();
            student.Teacher.Name = "Martina";

            student.Teacher.TeacherAddress = new Address();
            student.Teacher.TeacherAddress.PostCode = new Postcode();

            student.Teacher.TeacherAddress.PostCode.SecondPart = "8HA";

            var FullAddress = student.Teacher.TeacherAddress.GetFullAddress();


            Console.WriteLine(FullAddress);

            Console.ReadLine();



            //if (student.Age < 10)
            //{
            //    Console.WriteLine(student.FirstName);
            //    Console.ReadLine();
            //}

            //else if (student.Age >= 10)
            //{
            //    Console.WriteLine(student.LastName);
            //    Console.ReadLine();
            //}



        }

        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public Teacher Teacher { get; set; }

        }

    }

    public enum Gender

    {
        Male = 1,
        Female = 0

    }


    public class Teacher
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<Subject> Subjects { get; set; }

        public Gender Gender { get; set; }

        public Address TeacherAddress { get; set; }

    }

    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public Postcode PostCode { get; set; }

        public string GetFullAddress()
        {
            return $"The address is Street:{Street} City:{City} Postcode:{PostCode}.";
        }
    }


    public class Postcode

    {
        public string FirstPart { get; set; }

        public string SecondPart { get; set; }
    }



    public class Subject
    {
        public string Name { get; set; }
    }


}



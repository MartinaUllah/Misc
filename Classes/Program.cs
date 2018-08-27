using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address();

            var person = new Person();
            person.FirstName = "Martina";
            person.Gender = Gender.Male;
            var fullName = person.GetFullName("Martina", "ullah");
            //Console.WriteLine($" Name {person.FirstName} and gender {person.Gender}");
            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }

    public class Person
    {

        public Person()
        {

        }
        

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }


        public string GetFullName(string firstName, string lastName)
        {
            return $"First Name is {firstName} and last Name is {lastName}";
        }


    }

    public enum Gender
    {
        Male = 0,
        Female = 1

    }

    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }


    }
}


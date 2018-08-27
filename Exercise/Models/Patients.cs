using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
   public class Patients
    {
        public int ID { get; set; }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string DoctorName { get; set; }


        public string GetDiseases(string Disease1, string Disease2, string Disease3)
        {
            var diseases = Disease1 + Disease2 + Disease3;
            return diseases;
        }


        public string GetFullName(string FirstName, string Surname)
        {
            var fullName = $"Full name is: {FirstName} and {SurName}";
            return fullName;
        }


        public string GetDoctorQualification(string DoctorName, string Qualification)
        {
            var getDoctor = $"Full name is: {DoctorName} and {Qualification}";
            return getDoctor;
        }

        public int Testing()
        {
            Doctors doctor = new Doctors();
            doctor.FirstName = "Martina";



            int first = 6;
            Doctors doctorTest = new Doctors();

            int second = 9;

            

            int total = first + second;
            return total;
        }
    }
}

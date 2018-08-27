using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
   public class Doctors
    {
        public Doctors()
        {

        }

           

            public int ID { get; set; }

            public int Age { get; set; }

            public string FirstName { get; set; }

            public string Surname { get; set; }

            public string Qualifications { get; set; }


        public int GetTotalTime(int patientTime, int surgeryTime, int studyTime)
        {
            var totalTime = patientTime + surgeryTime + studyTime;
            return totalTime;
        }


        public string GetPatientFullName(string FirstName, string Surname)
        {            
            var patient = new Patients();
            var fullName = patient.GetFullName(FirstName, Surname);            
            return fullName;
        }

    }

}

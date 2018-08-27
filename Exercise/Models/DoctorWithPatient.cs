using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    class DoctorWithPatient
    {
       public string getName(string FirstName, string Surname)
        {
            var getFullName = new Doctors();
   
            var doctorname = getFullName.GetPatientFullName(FirstName, Surname);
            return doctorname;
        }

        public string GetPatientDiseases(string Disease1, string Disease2, string Disease3, Char a)
        {
            var patientDisease = new Patients();
            var diseases = patientDisease.GetDiseases(Disease1, Disease2, Disease3);
            return diseases;
        }
    }

}





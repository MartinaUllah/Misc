using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccessModifiers.Models
{
    public class SchoolStudent : Student
    {

        public void GetStudentFullName()
        {
            var firstnae = GetFirstName();

            
        }
    }

    public abstract class S
    {
     public int Age { get; set; }

    }

    public class G : S
    {

    }

    public class N : G
    {     

        public string Name()
        {           
            Age = 76;
            return Age.ToString();
        }
    }

    public class Z : T
    {
        public void Testing()
        {
            var tet = new G();
            tet.Age = 98;
        }
    }

    public class T
    {

    }

}

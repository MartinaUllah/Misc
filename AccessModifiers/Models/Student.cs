using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccessModifiers.Models
{
    public class Student
    {
        public string Name { get; set; }

        private string MyName { get; set; }

        public int GetYearlyGrades()
        {
            var totalAverage = (JanAverage() + MarchAverage() + OctAverage()) / 3;
            return totalAverage;
        }

        protected string GetFirstName()
        {
            return "Pusinka";
        }

        private int MarchAverage()
        {
            MyName = "sdfasfe";
            var myName = MyName;
            

            var marksInMarExams = new[] { 23, 66, 33 };
            var possibleExamsInMar = 7;
            var averageInMarch = marksInMarExams.Sum() / possibleExamsInMar;
            return averageInMarch;
        }

        private int OctAverage()
        {
            var marksInOctExams = new[] { 77, 26, 62 };
            var possibleExamsInOct = 3;
            var averageInOct = marksInOctExams.Sum() / possibleExamsInOct;
            return averageInOct;
        }

        private int JanAverage()
        {
            var marksInJanExams = new[] { 43, 56, 76 };
            var possibleExamsInJan = 5;
            var averageInJan = marksInJanExams.Sum() / possibleExamsInJan;
            return averageInJan;
        }        
    }
}
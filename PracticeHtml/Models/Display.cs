using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeHtml.Models
{
    public class Display
    {
        public decimal Earnings { get; set; }

        public string GetFullPath(string Server, string Path)
        {
            var totalPath = $"{Server}, {Path}.";

            return totalPath;
        }


    }
}
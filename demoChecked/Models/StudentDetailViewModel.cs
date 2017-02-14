using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoChecked.Models
{
    public class StudentDetailViewModel
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public string Course { get; set; }

        public Nationalities Nationalities { get; set; }
        public SelectListItem[] Sexes
        {
            get
            {
                var sexes = new List<SelectListItem>();
                var sexList = SexOptions.Sexes;
                foreach (var sex in sexList)
                {
                    sexes.Add(new SelectListItem { Text = sex, Value = sex });
                }

                return sexes.ToArray();
            }
        }

        public SelectListItem [] Courses
        {
            get
            {
                var courses = new List<SelectListItem>();
                var courseList = CourseOptions.Courses;
                foreach (var item in courseList)
                {
                    courses.Add(new SelectListItem { Text = item, Value = item });
                }

                return courses.ToArray();
            }
        }
    }
    
    public class SexOptions
    {
        public static readonly string[] Sexes = new[]
        {
            "Male",
            "Female"
        };
    }

    public class CourseOptions
    {
        public static readonly string[] Courses = new[]
        {
            "C#",
            "SQL Server",
            "ASP.NET"
        };
    }

    public enum Nationalities
    {
        Vietnam,
        USA,
        India
    }
}
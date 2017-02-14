using System.Collections.Generic;
using System.Web.Mvc;

namespace demoChecked.Models
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            StudentDetails = new StudentDetailViewModel();
        }
        public bool IsActive { get; set; }
        public Department Departments { get; set; }

        public StudentDetailViewModel StudentDetails { get; set; }

        public SelectListItem[] DepartmentList
        {
            get
            {
                var departmentOptions = new List<SelectListItem>();
                var departmentOptionsList = DepartmentOptions.Department;
                foreach (var item in departmentOptionsList)
                {
                    departmentOptions.Add(new SelectListItem { Text = item, Value = item });
                }

                return departmentOptions.ToArray();
            }
        }
    }

    public enum Department
    {
        IT,
        Sales,
        Marketing
    }

    public class DepartmentOptions
    {
        public static readonly string[] Department = new[]
        {
            "IT",
            "Sales",
            "Marketing"
        };
    }
}
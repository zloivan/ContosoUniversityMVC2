using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversityMVC2.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        [DataType(DataType.Currency),Column(TypeName ="money")]
        public decimal Budget { get; set; }
        [Display(Name ="Start Date"),DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }
        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
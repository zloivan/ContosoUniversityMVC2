using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversityMVC2.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Last name must be less than 50 characters."),Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50,ErrorMessage = "First name  must be less than 50 characters.")]
        [Display(Name ="First Name")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Hire Date")]
        public DateTime HireDate { get; set; }
        [Display(Name ="Full Name")]

        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversityMVC2.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [Display(Name ="Last Name"), StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "First Name / Mid Name"),StringLength(50,ErrorMessage ="First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        [Display(Name = "Enrollment Date"),DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

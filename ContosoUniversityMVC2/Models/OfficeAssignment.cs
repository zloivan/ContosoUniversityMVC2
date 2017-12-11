using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversityMVC2.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [Display(Name ="Office Location"),StringLength(50)]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }

    }
}
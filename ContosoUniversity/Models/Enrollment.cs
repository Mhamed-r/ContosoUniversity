using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A , B, C , D , F
    }


    public class Enrollment
    {
        // PK
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // Navigation Properties

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}
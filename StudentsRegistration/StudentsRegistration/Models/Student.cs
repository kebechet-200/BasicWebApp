using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }
    }
}
 
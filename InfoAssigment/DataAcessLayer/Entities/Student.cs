using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Entities
{
    public class Student
    {
        [Key]
        public Guid StdId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Rollno { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        [Required]
        public DateTime Dob {  get; set; } 
        public string Gender { get; set; } = string.Empty;
        public int? GradeId { get; set; }
        public Grade Grade { get; set; }
        public int? TeacherId { get; set; }
        public Teacher teacher { get; set; }    

    }
}

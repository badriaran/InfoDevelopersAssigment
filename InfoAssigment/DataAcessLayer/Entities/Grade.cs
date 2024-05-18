using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Entities
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; } = string.Empty;  
        public int? TeacherId { get; set; }  
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }


    }
}

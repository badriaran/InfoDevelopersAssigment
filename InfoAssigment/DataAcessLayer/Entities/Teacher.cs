using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Entities
{
    public class Teacher
    {
        [Key]
        public int GuidId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Student> students { get; set; }  



    }
}

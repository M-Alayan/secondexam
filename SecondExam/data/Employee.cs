using Microsoft.AspNetCore.Http;
using SecondExam.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [BDay]
        public DateTime Bday { get; set; }
        public string Path { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        [ForeignKey("dpt")]
        public int Dept_id { get; set; }
        [ForeignKey("cnt")]
        public int Country_id { get; set; }

        public Country cnt { set; get; }
        public Department dpt { set; get; }
    }
}
















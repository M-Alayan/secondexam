using SecondExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.Models
{
    public class VMemployee
    {
        public Employee employee { set; get; }
        public List<Country> licountry { set; get; }
        public List<Department> lidepartment { set; get; }
    }
}

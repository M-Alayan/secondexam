using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.data
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Minsalary { get; set; }
        public int Maxsalary { get; set; }

        public List<Employee> liemp {set;get;}
    }
}

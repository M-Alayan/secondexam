using SecondExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.service
{
    public class Departmentservice:IDepartmentservice
    {
        SEContext context;
        public Departmentservice(SEContext _context)
        {
            context = _context;
        }

        public List<Department> lidepartment()
        {
            List<Department> lidepartment = context.department.ToList();
            return lidepartment;
        }
        
    }
}

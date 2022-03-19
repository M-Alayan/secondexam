using SecondExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.service
{
    public class Employeeservice:IEmployeeservice
    {
        SEContext context;
        public Employeeservice(SEContext _context)
        {
            context = _context;
        }

        public void saveinfo(Employee emp)
        {
            context.employee.Add(emp);
            context.SaveChanges();
        }
        public List<Employee> liemploye(int Id)
        {
            List<Employee> liemploye = context.employee.Where(a => a.Dept_id == Id).ToList();
            return liemploye;
        }
        public void delete(int Id)
        {
            Employee emp = context.employee.Find(Id);
            context.employee.Remove(emp);
            context.SaveChanges();
        }
    }
}

using SecondExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.service
{
  public  interface IEmployeeservice
    {
        public void saveinfo(Employee emp);
        public List<Employee> liemploye(int Id);
        public void delete(int Id);
    }
}

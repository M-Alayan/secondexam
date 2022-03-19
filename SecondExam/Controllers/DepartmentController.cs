using Microsoft.AspNetCore.Mvc;
using SecondExam.data;
using SecondExam.Models;
using SecondExam.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.Controllers
{
    public class DepartmentController : Controller
    {
        IEmployeeservice eservice;
        IDepartmentservice dservice;
        public DepartmentController(IEmployeeservice _eservice, IDepartmentservice _dservice)
        {
            eservice = _eservice;
            dservice = _dservice;
            
        }
        public IActionResult Index()
        {
            VMdepartment vm = new VMdepartment();
            vm.lidepartments = dservice.lidepartment();
            vm.liemployee = new List<Employee>();
            return View("department",vm);
        }
        public IActionResult detailes(int Id)
        {
            VMdepartment vm = new VMdepartment();
            vm.lidepartments = dservice.lidepartment();
            vm.liemployee = eservice.liemploye(Id);
            return View("department", vm);

        }
        public IActionResult delete(int Id)
        {
            eservice.delete(Id);
            VMdepartment vm = new VMdepartment();
            vm.lidepartments = dservice.lidepartment();
            vm.liemployee = new List<Employee>();
            return View("department", vm);
        }
    }
}

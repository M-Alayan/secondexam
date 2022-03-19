using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SecondExam.Models;
using SecondExam.service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeservice eservice;
        IDepartmentservice dservice;
        ICountryservice cservice;
        IConfiguration config;

        public EmployeeController(IEmployeeservice _eservice, IDepartmentservice _dservice, ICountryservice _cservice, IConfiguration _config)
        {
            eservice = _eservice;
            dservice = _dservice;
            cservice = _cservice;
            config = _config;
        }
        public IActionResult Index()
        {
            VMemployee vm = new VMemployee();
            vm.licountry = cservice.licountry();
            vm.lidepartment = dservice.lidepartment();

            return View("employee",vm);
          
        }
        public IActionResult saveinfo(VMemployee model)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), config["Filepath"], model.employee.Image.FileName);
            model.employee.Image.CopyTo(new FileStream(path, FileMode.Create));
            model.employee.Path = "http://localhost/secoundexam/img/" + model.employee.Image.FileName;

            if (ModelState.IsValid == true)
            {
                eservice.saveinfo(model.employee);
            }
            VMemployee vm = new VMemployee();
            vm.licountry = cservice.licountry();
            vm.lidepartment = dservice.lidepartment();

            return View("employee", vm);

        }
    }
}

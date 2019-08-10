using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMvcApp.Models;
using DotNetCoreMvcApp.EmployeeService;
using System.Web.Providers.Entities;

namespace DotNetCoreMvcApp.Controllers
{
    //[Route("EmployeeBoard")] 
    public class EmployeeController : Controller
    {
        //Injecting Employee Service in constructor of EmployeeController  here.

        private readonly IEmployeeService _repository;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._repository = employeeService;
        }

        [HttpGet] 
        [ActionName("EmployeeBoard")] 
        public ActionResult EmployeeBoard()
        {
           
            return View(this._repository.GetEmployees());
        }

        [HttpGet]
        public ActionResult GetEmployeebyid(int id)
        {
            return View(this._repository.FindEmployee(id));
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }

         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee([Bind(include:"EmployeeId,FirstName,LastName,DOB,Country,Department,Phone,ProfileUrl,Email")] EmployeeModel employee)
        {
            try
            {
                if(ModelState.IsValid)
                { 
                    IList<EmployeeModel> EmploeeUpdate = this._repository.CreateEmployee(employee);
                    List<EmployeeModel> LatestRecord = new List<EmployeeModel>();
                    LatestRecord.Add(EmploeeUpdate[EmploeeUpdate.Count() - 1]);
                    TempData["EmployeeCreated"] = true;
                    return View("EmployeeBoard", LatestRecord);
                }

                return RedirectToAction(nameof(EmployeeBoard));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            return View(this._repository.FindEmployee(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmployee([Bind(include: "EmployeeId,FirstName,LastName,DOB,Country,Department,Phone,ProfileUrl,Email")]EmployeeModel employee,string showlog)
        {
            try
            {
                if (ModelState.IsValid)
                { 
                    IList<EmployeeModel> EmploeeUpdate = this._repository.UpdateEmployee(employee);
                    List<EmployeeModel> LatestRecord = new List<EmployeeModel>();
                    LatestRecord.Add(EmploeeUpdate[EmploeeUpdate.Count()-1]);
                    TempData["EmployeeUpdate"] = true;
                    return View("EmployeeBoard", LatestRecord);
                } 

                return RedirectToAction(nameof(EmployeeBoard));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            return View(this._repository.FindEmployee(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteEmployee")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IList<EmployeeModel> Employee = this._repository.DeleteEmployee(id);
                    TempData["EmployeeDeleted"] = true;
                    ViewBag.deleteEmployee = this._repository.GetEmployeeById(id).FirstOrDefault().FirstName;
                    return View("EmployeeBoard", Employee);
                }

                return RedirectToAction(nameof(EmployeeBoard));
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);    
        }
    }
}
using DotNetCoreMvcApp.EmployeeService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreMvcApp.Models
{
    public class EmployeeModel
    {
        //Employee model MVC class Data validation with System.ComponentModel.DataAnnotations
        public int EmployeeId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Employee Name is Required")]
        [MinLength(2, ErrorMessage = "Employee Name length should be > 2 characters.")]
        [MaxLength(10, ErrorMessage = "Employee Name length should be < 10 characters")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Employee LastName is Required")]
        [MinLength(2, ErrorMessage = "Employee LastName length should be > 2 characters.")]
        [MaxLength(10, ErrorMessage = "Employee LastName length should be < 10 characters")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Employee DOB is Required")]
        [MinLength(2, ErrorMessage = "Employee DOB length should be > 2 characters.")]
        [MaxLength(10, ErrorMessage = "Employee DOB length should be < 10 characters")]
        public string DOB { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Employee Country is Required")]
        [MinLength(2, ErrorMessage = "Employee Country length should be > 2 characters.")]
        [MaxLength(10, ErrorMessage = "Employee Country length should be < 10 characters")]
        public string Country { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Employee Department is Required")]
        [MinLength(2, ErrorMessage = "Employee Department length should be > 2 characters.")]
        [MaxLength(10, ErrorMessage = "Employee Department length should be < 10 characters")]
        public string Department { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Employee Phone is Required")]
        [MinLength(10, ErrorMessage = "Employee Phone length should be >= 10 characters.")]
        [MaxLength(10, ErrorMessage = "Employee Phone length should be < 10 characters")]
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Employee ProfileUrl is Required")]
        [MinLength(2, ErrorMessage = "Employee ProfileUrl length should be > 2 characters.")]
        [MaxLength(100, ErrorMessage = "Employee ProfileUrl length should be < 10 characters")]
        public string ProfileUrl { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Employee Email is Required")]
        [MinLength(2, ErrorMessage = "Employee Email length should be > 2 characters.")]
        [MaxLength(50, ErrorMessage = "Employee Email length should be < 10 characters")]
        public string Email { get; set; }
    }

    //IEmployee  service implementation 

    public class Employeeservice : IEmployeeService
    {
        public List<EmployeeModel> Employeemodel => new List<EmployeeModel>();
        public static string Img1 { get; } = "https://localhost:44386/Pictures/F4.JPG";
        public static string Img2 { get; } = "https://localhost:44386/Pictures/f3.JPG";
        public static string Img3 { get; } = "https://localhost:44386/Pictures/m3.Png";
        public static string Img4 { get; } = "https://localhost:44386/Pictures/m4.JPG";

        private static List<EmployeeModel> GetEmployeeContext()
        {
            var employees = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    EmployeeId = 100,
                    FirstName = "Jhon",
                    LastName = "mello",
                    Country = "US",
                    Department = "IT",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "010009090",
                    ProfileUrl = Img3
                },
                new EmployeeModel()
                {
                    EmployeeId = 101,
                    FirstName = "Merry",
                    LastName = "M",
                    Country = "US",
                    Department = "HR",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "010049090",
                    ProfileUrl = Img1
                },
                new EmployeeModel()
                {
                    EmployeeId = 102,
                    FirstName = "George ",
                    LastName = "Loe",
                    Country = "Russia",
                    Department = "IT",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "010059090",
                    ProfileUrl = Img4
                },
                new EmployeeModel()
                {
                    EmployeeId = 103,
                    FirstName = "Jacob",
                    LastName = "Joshep",
                    Country = "UK",
                    Department = "HR",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "030009090",
                    ProfileUrl = Img2
                },
                new EmployeeModel()
                {
                    EmployeeId = 104,
                    FirstName = "Rakesh",
                    LastName = "Singh",
                    Country = "India",
                    Department = "IT",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "410009090",
                    ProfileUrl = Img3
                },
                new EmployeeModel()
                {
                    EmployeeId = 105,
                    FirstName = "Jack",
                    LastName = "kom",
                    Country = "Russia",
                    Department = "Admin",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "670009090",
                    ProfileUrl = Img4
                },
                new EmployeeModel()
                {
                    EmployeeId = 106,
                    FirstName = "Minto",
                    LastName = "tom",
                    Country = "US",
                    Department = "Admin",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "0100149090",
                    ProfileUrl = Img3
                },
                new EmployeeModel()
                {
                    EmployeeId = 107,
                    FirstName = "Oscar",
                    LastName = "S",
                    Country = "US",
                    Department = "IT",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "010789090",
                    ProfileUrl = Img3
                },
                new EmployeeModel()
                {
                    EmployeeId = 108,
                    FirstName = "V.K",
                    LastName = "Singh",
                    Country = "India",
                    Department = "Admin",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "010000090",
                    ProfileUrl = Img4
                },
                new EmployeeModel()
                {
                    EmployeeId = 109,
                    FirstName = "Harry",
                    LastName = "pitter",
                    Country = "UK",
                    Department = "IT",
                    DOB = DateTime.Now.ToShortDateString(),
                    Email = "example@employee.com",
                    Phone = "010077090",
                    ProfileUrl = Img3
                }
            };
            return employees;
        }

        IList<EmployeeModel> IEmployeeService.GetEmployees()
        {
            return GetEmployeeContext();
        }

        IList<EmployeeModel> IEmployeeService.GetEmployeeById(int id)
        {
            return GetEmployeeContext().Where(emp => emp.EmployeeId == id).ToList();
        }

        IList<EmployeeModel> IEmployeeService.CreateEmployee(EmployeeModel employee)
        {
            try
            {
                var emp = new EmployeeModel
                {
                    DOB = employee.DOB,
                    Email = employee.Email,
                    Phone = employee.Phone,
                    Country = employee.Country,
                    LastName = employee.LastName,
                    FirstName = employee.FirstName,
                    Department = employee.Department,
                    ProfileUrl = employee.ProfileUrl,
                    EmployeeId = employee.EmployeeId
                };
                Employeemodel.Add(emp);
                return Employeemodel;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        IList<EmployeeModel> IEmployeeService.UpdateEmployee(EmployeeModel employee)
        {
            var emp = GetEmployeeContext().SingleOrDefault(e => e.EmployeeId == employee.EmployeeId);
            if (emp != null) return new List<EmployeeModel>();
            emp.DOB = employee.DOB;
            emp.Email = employee.Email;
            emp.Phone = employee.Phone;
            emp.Country = employee.Country;
            emp.LastName = employee.LastName;
            emp.FirstName = employee.FirstName;
            emp.Department = employee.Department;
            emp.ProfileUrl = employee.ProfileUrl;
            emp.EmployeeId = employee.EmployeeId;
            Employeemodel.Add(emp);
            return Employeemodel;
        }

        IList<EmployeeModel> IEmployeeService.DeleteEmployee(int id)
        {
            var emp = GetEmployeeContext().SingleOrDefault(e => e.EmployeeId == id);
            return emp != null
                ? GetEmployeeContext().Where(e => e.EmployeeId != emp.EmployeeId).ToList()
                : new List<EmployeeModel>();
        }

        EmployeeModel IEmployeeService.FindEmployee(int id)
        {
            return GetEmployeeContext().SingleOrDefault(e => e.EmployeeId == id);
        }
    }
}

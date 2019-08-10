using DotNetCoreMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreMvcApp.EmployeeService
{
    public interface IEmployeeService
    {
        IList<EmployeeModel>  GetEmployees();

        IList<EmployeeModel> GetEmployeeById(int id);

        IList<EmployeeModel> CreateEmployee(EmployeeModel employee);

        IList<EmployeeModel> UpdateEmployee(EmployeeModel employee);

        IList<EmployeeModel> DeleteEmployee(int id);

        EmployeeModel FindEmployee(int id);
    }
}

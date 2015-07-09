using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityFramework_DesignFirst.Models;

namespace EntityFramework_DesignFirst.DAL
{
    public class EmployeeRepository
    {
        #region Design (database) first approach

        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public object GetEmployee() // get an information of employees using sp
        {
            var employeeList = from x in employeeDBContext.spGetEmployeeDetails()
                               orderby x.ID
                               select new { x.FirstName, x.LastName, x.Salary };
            return employeeList.ToList();
        }

        public object GetDepartment() // get an information of department using sp
        {
            var departmentList = from x in employeeDBContext.spGetDepartmentDetails()
                                 orderby x.ID
                                 select x;
            return departmentList.ToList();
        }

        public void InsertEmployeeDetail(Employee employee) // perform insertion of employee details using SP
        {
            employeeDBContext.spInsertEmployeeDetails(employee.FirstName, employee.LastName, employee.Gender, employee.Salary, employee.DepartmentId);
            employeeDBContext.SaveChanges();
        }

        #endregion

    }
}
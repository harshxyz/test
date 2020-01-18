using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApi.Models;


namespace FirstWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeDB obj = new EmployeeDB();

        public IEnumerable<Employee> Get()
        {
            return obj.Employees;
        }

        //Employee[] employeelist = new Employee[]
        //{
        //    new Employee{ EmpId=1,Address="Thane",Name="Somename"},
        //    new Employee{ EmpId=2,Address="Borivali",Name="Somename2"},
        //};
        //public IEnumerable<Employee> Get()
        //{
        //    return employeelist;
        //}
    }
}

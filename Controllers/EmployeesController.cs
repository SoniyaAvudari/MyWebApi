using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("GetAllEmployees")]
        public List<EmployeesClass> GetAllEmployees()
        {
            EmployeesModel objEmployeesModel = new EmployeesModel();
            List<EmployeesClass> listEmployees = objEmployeesModel.GetAllEmployees();
            return listEmployees;

        }

        [HttpGet("GetEmployeeByid")]
        public List<EmployeesClass> GetEmployeeByid(int iEmployeeid)
        {
            EmployeesModel objemployeesModel = new EmployeesModel();
            List<EmployeesClass> employees = objemployeesModel.GetEmployeeByid(iEmployeeid);
            return employees;


        }
    }
}

       
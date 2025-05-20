using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet("GetAllCustomers")]
        public List<CustomerClass> GetAllCustomers()
        {
            CustomerModel objCustomerModel = new CustomerModel();
            List<CustomerClass> lstsCustomerClasses = objCustomerModel.GetAllCustomers();
            return lstsCustomerClasses;
        }

        [HttpGet("GetAllCustomersById")]
        public List<CustomerClass> GetAllCustomersById(int iCustomerID)
        {
            CustomerModel objCustomerModel = new CustomerModel();
            List<CustomerClass> customers = objCustomerModel.GetAllCustomersById(iCustomerID);
            return customers;

        }
    }
}

             




using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet("GetAllOrders")]
        public List<OrdersClass> GetAllOrders()
        {
            OrdersModel objOrdersModel = new OrdersModel();
            List<OrdersClass> orders = objOrdersModel.GetAllOrders();
            return orders;

        }

        [HttpGet("GetOrderdetailbyid")]
        public List<OrdersClass> Getorderbyorderid(int iORDERID)
        {
            OrdersModel objordersModel = new OrdersModel();
            List<OrdersClass> orders= objordersModel.Getorderbyorderid(iORDERID);
            return orders;
        }

    }
}

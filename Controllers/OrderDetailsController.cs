using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        [HttpGet("GetAllOrderDetails")]
        public List<OrderDetailsClass> GetAllOrderDetails()
        {
            OrderDetailsModel objorderDetailsModel = new OrderDetailsModel();
            List<OrderDetailsClass> LSTOrderDetails = objorderDetailsModel.GetAllOrderDetails();
            return LSTOrderDetails;
        }

        [HttpGet("GetOrderDetailbyid")]
        public List<OrderDetailsClass> GetOrderDetailbyid(int iOrderDetails)
        {
           OrderDetailsModel objOrderDetailsModel = new OrderDetailsModel();
            List<OrderDetailsClass> orderDetails=objOrderDetailsModel.GetOrderDetailbyid(iOrderDetails);
            return orderDetails;


        }

    }
}


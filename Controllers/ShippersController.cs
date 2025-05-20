using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippersController : ControllerBase
    {
        [HttpGet("GetAllShippers")]
        public List<ShippersClass> GetAllShippers()
        {
            ShippersModel objshippersModel = new ShippersModel();
            List<ShippersClass> shippers = objshippersModel.GetAllShippers();
            return shippers;


        }

        [HttpGet("GETSHIPPERSBYSHIPPERID")]

        public List<ShippersClass> GETSHIPPERSBYSHIPPERID(int iShipperID)
        {
            ShippersModel objshippersModel = new ShippersModel();
            List<ShippersClass> shippers=objshippersModel.GETSHIPPERSBYSHIPPERID(
                iShipperID);
            return shippers;

        }
    }
}

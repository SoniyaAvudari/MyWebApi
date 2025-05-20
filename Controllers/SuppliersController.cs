using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        [HttpGet("GetAllSuppliers")]
        public List<SuppliersClass> GetAllSuppliers()

        {
            SupplierModel objsupplierModel = new SupplierModel();
            List<SuppliersClass> suppliers = objsupplierModel.GetAllSuppliers();
            return suppliers;

        }

        [HttpGet("GETSUPPLIERSBYSUPPLIERID")]

        public List<SuppliersClass> GETSUPPLIERSBYSUPPLIERID(int iSupplierID)
        {
            SupplierModel objsupplierModel = new SupplierModel();
            List<SuppliersClass> suppliers=objsupplierModel.GETSUPPLIERSBYSUPPLIERID(
                iSupplierID);
            return suppliers;

        }

    }
}

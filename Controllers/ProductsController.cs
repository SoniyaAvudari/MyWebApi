using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetAllProducts")]
        public List<ProductsClass> GetAllProducts()
        {
            ProductsModel objproductsModel = new ProductsModel();
            List<ProductsClass> products = objproductsModel.GetAllProducts();
            return products;

        }

        [HttpGet("Getproductsbyproductid")]
        public List<ProductsClass> Getproductsbyproductid(int iProductID)
        {
            ProductsModel objproductsModel = new ProductsModel();
            List<ProductsClass> products = objproductsModel.Getproductsbyproductid(iProductID);
            return products;

        }
    }
}


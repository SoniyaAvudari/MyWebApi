using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDbLib;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet("GetAllCategories")]
        public List<CategoriesClass> GetAllCategories()
        {
            CategoriesModel objCategoriesModel= new CategoriesModel();
            List<CategoriesClass> lstCategories=objCategoriesModel.GetAllCategories();
            return lstCategories;
        }

        [HttpGet("Getcategorybyid")]

        public List<CategoriesClass> Getcategorybyid(int iCategory)
        {
            CategoriesModel objcategoriesModel= new CategoriesModel();
            List<CategoriesClass> categories = objcategoriesModel.Getcategorybyid(iCategory);
            return categories;


        }



    }
}

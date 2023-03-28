using Microsoft.AspNetCore.Mvc;

namespace _01_backend
{
    public class ProductController : Controller
    {
    
        public ContentResult Detail(int id)
        {
            ContentResult result = new ContentResult();
            result.Content = "Product id:" + id;
            return result;
        }
    }
}

using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models;

namespace MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
    }
}

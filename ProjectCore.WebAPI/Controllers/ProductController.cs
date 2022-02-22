using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Application.Catalog.Categories;
using ProjectCore.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly ICategoryService _categoryService;

        public ProductController(ICategoryService categoryService) {
            this._categoryService = categoryService;
        }

        [HttpGet]
        public Task<List<CategoryVm>> GetAllCategory() {
           return _categoryService.GetAll("vi");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Data;
using WebAPIApp.Models;
using WebAPIApp.Services.Categories;

namespace WebAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        //HTTP GET >> api/Categories
        // CategoriesController c = new CategoriesController(......);
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        //  private ApplicationDbContext dbContext = new ApplicationDbContext();
        [HttpGet]
        public IActionResult GetCategories()
        {
            var model = categoryService.GetAll();
            //paging, filter 
            return Ok(new { success = true, data = model });
        }

        [HttpPost]
        public IActionResult Post(InputCategory model)
        {
            var result = categoryService.Create(model);
            //paging, filter 
            return Ok(new { success = result.Success, Message = result.Message });
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, InputCategory model)
        {
            var result = categoryService.Update(id, model);
            //paging, filter 
            return Ok(new { success = result.Success, Message = result.Message });
        }

    }
}

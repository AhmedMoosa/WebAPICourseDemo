using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Services;

namespace WebAPIApp.Controllers
{
    //api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<string> names = new List<string> { "aaaa", "bbbb", "cccc" };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(names);
        }
        //{controller}/{action}/{parameter}
        [HttpPost]
        public IActionResult Post([FromBody]string value, [FromServices] IProductRepository productRepo)
        {
            names.Add(value);
            names.Add(productRepo.Find(0));
            return Ok(names);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] string name, int id)
        {
            names.Add("updated");
            return Ok(names);
        }

        [HttpDelete]
        public IActionResult Delete(string name)
        {
            names.Remove(name);
            return Ok(names);
        }

    }
}

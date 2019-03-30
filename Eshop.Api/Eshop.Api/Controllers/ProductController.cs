using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace Eshop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok();
        }
        // POST api/product
        [HttpPost]
        public IActionResult Post([FromBody] ProductItem item)
        {
            return Ok();
        }
        // PUT api/product/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] ProductItem item)
        {
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok();
        }
    }
}

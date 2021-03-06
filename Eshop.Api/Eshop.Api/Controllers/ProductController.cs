﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace Eshop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _srv;
        public ProductController(IProductService srv)
        {
            _srv = srv;
        }


        // GET api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_srv.GetAll());
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return BadRequest("Invalid Id");
                }
                var result = _srv.GetProductItem(id);

                return Ok(result);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }
        // POST api/product
        [HttpPost]
        public IActionResult Post([FromBody] ProductItem item)
        {
            try
            {
                var result = _srv.InsertProductItem(item);
                return Ok(item);
            }
            catch(Exception)
            {
                return BadRequest("Something went wrong");
            }
        }
        // PUT api/product/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] ProductItem productItem)
        {
            if (productItem == null) return BadRequest("Error Mate");
            var updatedProductItem = _srv.Update(productItem);
            if (updatedProductItem == null) return BadRequest("Better Go fishing");
            return new ObjectResult(_srv.Update(productItem));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                if(string.IsNullOrEmpty(id))
                {
                    return BadRequest("Invalid Id");
                }
                var success = _srv.DeleteProductItem(id);
                return Ok(success);
            }
            catch(Exception ex)
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}

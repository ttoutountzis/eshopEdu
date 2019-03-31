using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Api.Context;
using Eshop.Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace Eshop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _srv;

        public UserController(IUserService srv)
        {
            _srv = srv;
        }


        // GET api/users
        [HttpGet]
        public IActionResult GetAll()
        {



            return Ok();
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return BadRequest("Invalid Id");
                }
                var result = _srv.GetUser(id);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Something went Wrong");
            }

        }
        // POST api/user
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                var result = _srv.InsertUser(user);
                return Ok(user);
            }
            catch (Exception )
            {
                return BadRequest("Something went Wrong");
            }
        }

        // PUT api/product/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] User user)
        {
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return BadRequest("Invalid Id");
                }

                var success = _srv.DeleteUser(id);

                return Ok(success);
            }
            catch (Exception ex)
            {
                return BadRequest("Something went Wrong");
            }
        }
    }
}
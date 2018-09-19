using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mooadmin.Ngx.AspNetCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mooadmin.Ngx.AspNetCore.Controllers
{
    [Route("api/foods")]
    public class FoodsController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<Food>> Get()
        {
            return await Task.FromResult(new List<Food> { new Food { Name = "Rendang", Calories = 100, Created = DateTime.Now, Type = "Main Course" } });
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

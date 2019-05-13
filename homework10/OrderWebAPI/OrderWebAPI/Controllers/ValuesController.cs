using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderWebAPI.Models;

namespace OrderWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly OrderService orderservice;
        public ValuesController(OrderService orderservice)
        {
            this.orderservice = orderservice;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            return orderservice.Allorders();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(string id)
        {
            var item = orderservice.GetOrder(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Order> PostNew(Order item)
        {
            try {
                item.Id = Guid.NewGuid().ToString();
                orderservice.add(item);
            }
            catch(Exception e){ return BadRequest(e.InnerException.Message); }
            return item;
        }
 

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Order> Put_Modify(string id,Order item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            try { orderservice.modify(item); }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Order> Delete(string id)
        {
            try { orderservice.delete(id); }
            catch(Exception e) { return BadRequest(e.InnerException.Message); }
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using pizzas_mama.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizzas_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        DataContext dataContext;
        public ApiController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        // GET: api/<ApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var pizza = new Pizza() { nom = "Margherita", prix = 7.5, vegetarienne = true, ingredients = "Base tomate, mozzarella di Buffala, olives, basilic frais" };
            return Json(pizza);
        }

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

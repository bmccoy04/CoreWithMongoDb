using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWithMongoDb.WebApi.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace CoreWithMongoDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RestaurantsController : Controller
    {
        RestaurantRepo _restaurantRepo;
        public RestaurantsController(){
            _restaurantRepo = new RestaurantRepo();
        }

        // GET api/Restaurants
        [HttpGet]
        public IActionResult Get()
        {    
            try
            {
                return Ok(_restaurantRepo.Get());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw ex; 
            }
        }

        // GET api/Restaurants/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Restaurants
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Restaurants/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Restaurants/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

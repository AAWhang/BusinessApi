using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessApi.Models;

namespace BusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private BusinessApiContext _db = new BusinessApiContext();

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Shop>> Get()
        {
            return _db.Shops.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Shop animal)
        {
            _db.Shops.Add(animal);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Shop> Get(int id)
        {
            return _db.Shops.FirstOrDefault(x => x.ShopId == id);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Shop shop)
        {
            shop.ShopId = id;
            _db.Entry(shop).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var shopToDelete = _db.Shops.FirstOrDefault(x => x.ShopId == id);
            _db.Shops.Remove(shopToDelete);
            _db.SaveChanges();
        }
    }
}

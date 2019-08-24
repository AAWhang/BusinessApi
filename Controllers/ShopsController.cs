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

        // GET api/shops
        [HttpGet]
        public ActionResult<IEnumerable<Shop>> Get()
        {
            return _db.Shops.ToList();
        }

        // POST api/shops
        [HttpPost]
        public void Post([FromBody] Shop shop)
        {
            _db.Shops.Add(shop);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Shop> Get(int id)
        {
          Random rand = new Random();
          int intIdt = _db.Shops.Max(u => (int)u.ShopId);
          id = rand.Next(intIdt);
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

        [Route("random")]
        public ActionResult<Shop> random()
        {
          Random rand = new Random();
          int intIdt = _db.Shops.Max(u => (int)u.ShopId);
          int id = rand.Next(intIdt);
            return _db.Shops.FirstOrDefault(x => x.ShopId == id);
        }
    }
}

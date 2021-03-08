using Ecom.Data;
using Ecom.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Products:ControllerBase
    {
        private readonly StoreContext _storeContext;

        public Products(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpGet]
        public async Task<ActionResult<Product>> GetProducts()
        {
            var result = await _storeContext.Products.ToListAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id )
        {
            var result = await _storeContext.Products.FindAsync(id);
            return Ok(result);
        }


    }
}

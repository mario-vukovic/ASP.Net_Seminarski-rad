﻿using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models.Dbo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Seminarski_rad.Controllers.API
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : Controller
    {
        private readonly ApplicationDbContext db;

        public APIController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("Products")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProducts()
        {
            var dbo = await db.Product.ToListAsync();
            return Ok(dbo.Select(x=>x).ToList());
        }

        [HttpGet]
        [Route("Product/{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetItem(int id)
        {
            var dbo = await db.Product.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(dbo);
        }
    }
}

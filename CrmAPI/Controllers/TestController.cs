﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmBL.Interfaces;
using CrmDL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IBaseEntityService<Brand> _brandService;

        public TestController(IBaseEntityService<Brand> brandService)
        {
            _brandService = brandService;
        }

        // GET: api/Test
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = await _brandService.GetAll().ToListAsync();
            return Ok(res);
;
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cookie_stand_api.Data;
using cookie_stand_api.Models;
using cookie_stand_api.Models.Interfaces;

namespace cookie_stand_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookiestandsController : ControllerBase
    {
        private readonly ICookiestand _context;

        public CookiestandsController(ICookiestand context)
        {
            _context = context;
        }

        // GET: api/Cookiestands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cookiestand>>> GetCookiestands()
        {
            return await _context.GetAll();
        }

        // GET: api/Cookiestands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cookiestand>> GetCookiestand(int id)
        {
            await _context.GetById(id);
            return Ok();
        }

        // PUT: api/Cookiestands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCookiestand(int id, Cookiestand cookiestand)
        {
            await _context.Put(id, cookiestand);
            return Ok();
        }

        // POST: api/Cookiestands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cookiestand>> PostCookiestand(Cookiestand newCookieStand)
        {
            return await _context.Post(newCookieStand);
        }

        // DELETE: api/Cookiestands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCookiestand(int id)
        {
            await _context.Delete(id);
            return NoContent();
        }

        //[HttpPut("{id}/hourly-sales")]
        //public async Task<IActionResult> UpdateHourlySales(int id, List<int> hourlySales)
        //{
        //    await _context.UpdateHourlySales(id, hourlySales);
        //    return NoContent();
        //}

    }
}

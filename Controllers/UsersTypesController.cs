using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApi;
using UsersApi.Data;

namespace UsersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/UsersTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersType>>> GetUsersType()
        {
            return await _context.UsersType.ToListAsync();
        }

        // GET: api/UsersTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsersType>> GetUsersType(int id)
        {
            var usersType = await _context.UsersType.FindAsync(id);

            if (usersType == null)
            {
                return NotFound();
            }

            return usersType;
        }

        // PUT: api/UsersTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsersType(int id, UsersType usersType)
        {
            if (id != usersType.Id)
            {
                return BadRequest();
            }

            _context.Entry(usersType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UsersTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsersType>> PostUsersType(UsersType usersType)
        {
            _context.UsersType.Add(usersType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsersType", new { id = usersType.Id }, usersType);
        }

        // DELETE: api/UsersTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsersType(int id)
        {
            var usersType = await _context.UsersType.FindAsync(id);
            if (usersType == null)
            {
                return NotFound();
            }

            _context.UsersType.Remove(usersType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsersTypeExists(int id)
        {
            return _context.UsersType.Any(e => e.Id == id);
        }
    }
}

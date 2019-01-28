using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HMS.DatabaseConnection;
using HMS.Models;

namespace HMS.Controllers
{

	[Produces("application/json")]

	[Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly HMSContext _context;

        public LoginsController(HMSContext context)
        {
            _context = context;
        }

        // GET: api/Logins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLogin()
        {
            return await _context.Login.ToListAsync();
        }

        // GET: api/Logins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Login>> GetLogin(int id)
        {
            var login = await _context.Login.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return login;
        }

        // PUT: api/Logins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogin(int id, Login login)
        {
            if (id != login.LoginId)
            {
                return BadRequest();
            }

            _context.Entry(login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(id))
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

        // POST: api/Logins
        [HttpPost]
        public async Task<ActionResult<Login>> PostLogin(Login login)
        {
            _context.Login.Add(login);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogin", new { id = login.LoginId }, login);
        }

        // DELETE: api/Logins/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Login>> DeleteLogin(int id)
        {
            var login = await _context.Login.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }

            _context.Login.Remove(login);
            await _context.SaveChangesAsync();

            return login;
        }

        private bool LoginExists(int id)
        {
            return _context.Login.Any(e => e.LoginId == id);
        }
    }
}

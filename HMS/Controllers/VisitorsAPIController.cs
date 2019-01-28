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

    //[Route("api/VisitorsAPI")]
    [ApiController]
    public class VisitorsAPIController : ControllerBase
    {
        private readonly HMSContext _context;

		public VisitorsAPIController(HMSContext context)
        {
            _context = context;
        }

		// GET: api/VisitorsAPI
		[Route("~/api/VisitorsAPI/GetVisitor")]
		[HttpGet]
		public IEnumerable<Visitor> GetVisitor()
		{
			var list = _context.Visitor.ToList();
			return list;
		}
	
		

		[Route("/GetVisitorList")]
		[HttpPost]
		public IEnumerable<Visitor> GetVisitorList([FromBody]Search searchstring)
		{
			//Search garne Query VisitorName bta 
			if (String.IsNullOrEmpty(searchstring.searchstring))
			{
				var list = _context.Visitor.ToList();
				return list;
			}
			else
			{
				var visitors = _context.Visitor.Where(s => s.VisitorName.ToLower().Contains(searchstring.searchstring.ToLower())).ToList();
				return visitors; 			  
			}
			//return await _context.Visitor.ToListAsync();
        }

		// GET: api/VisitorsAPI/5
		[Route("~/api/VisitorsAPI/GetVisitor/{id}"), HttpGet]
		
        public async Task<ActionResult<Visitor>> GetVisitor(int id)
        {
            var visitor = await _context.Visitor.FindAsync(id);

            if (visitor == null)
            {
                return NotFound();
            }

            return visitor;
        }
		// PUT: api/VisitorsAPI/5
		[Route("PutVisitor/{id}"), HttpPut]
		
        public async Task<IActionResult> PutVisitor(int id, Visitor visitor)
        {
            if (id != visitor.VisitorId)
            {
                return BadRequest();
            }

            _context.Entry(visitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitorExists(id))
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


		[Route("~/api/VisitorsAPI/PutVisitor"), HttpPost]
		public async Task<IActionResult> PutVisitor([FromBody] Visitor visitor)
		{

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var v = await _context.Visitor.FindAsync(visitor.VisitorId);
			v.VisitorName = visitor.VisitorName;
			v.VisitorAddress = visitor.VisitorAddress;
			v.VisitorPhoneNo = visitor.VisitorPhoneNo;
			v.VisitorEmail = visitor.VisitorEmail;


			_context.Entry(v).State = EntityState.Modified;
			await _context.SaveChangesAsync();

			return Ok("Updated");
		}

		// POST: api/VisitorsAPI
		[Route("~/api/VisitorsAPI/CreateVisitor"), HttpPost]
		public async Task<ActionResult<Visitor>> PostVisitor([FromBody]Visitor visitor)
        {
            _context.Visitor.Add(visitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisitor", new { id = visitor.VisitorId }, visitor);
        }

        // DELETE: api/VisitorsAPI/5
        [ Route("~/api/VisitorsAPI/DeleteVisitor/{id}"), HttpDelete]
        public async Task<ActionResult<Visitor>> DeleteVisitor(int id)
        {
            var visitor = await _context.Visitor.FindAsync(id);
            if (visitor == null)
            {
                return NotFound();
            }

            _context.Visitor.Remove(visitor);
            await _context.SaveChangesAsync();

            return visitor;
        }

        private bool VisitorExists(int id)
        {
            return _context.Visitor.Any(e => e.VisitorId == id);
        }
    }
}

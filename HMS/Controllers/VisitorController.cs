using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.DatabaseConnection;
using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HMS.Controllers
{
    public class VisitorController : Controller
    {
		protected readonly HMSContext _dbContext;

		public VisitorController(HMSContext dbcontext)
		{
			_dbContext = dbcontext;
		}

		// Visitor ko list show gareko Index ma ie LIST show gareko 
        public async Task<IActionResult> Index()
        {
			var visitor = await  _dbContext.Visitor.ToListAsync();
            return View(visitor);
        }

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Create([Bind("VisitorName, VisitorAddress, VisitorPhoneNo, VisitorEmail")] Visitor visitor)
		{
			if (ModelState.IsValid)
			{
				_dbContext.Add(visitor);
				 await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(visitor);

		}

	[HttpGet]
	 public async Task<IActionResult> Edit (int? id)
		{
			
			if (id==null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				var visitor = await  _dbContext.Visitor.FindAsync(id);
				return View(visitor);
			}
		
		}
	[HttpPost]
	public async Task<IActionResult> Edit (int? id, Visitor visitor)
		{
			if (ModelState.IsValid)
			{			
			if (id== null )
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				_dbContext.Update(visitor);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
		
		}
			return View(visitor);
		}
		[HttpGet]
		public async Task<IActionResult> Details (int? id)
		{
			
				var visitors = await _dbContext.Visitor.FindAsync(id);
				return View(visitors);
			
		}



		[HttpGet]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id==null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				var visitors = await _dbContext.Visitor.FindAsync(id);
				return View(visitors);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Delete(int? id, Visitor visitor)
		{
			if (ModelState.IsValid)
			{ 
			if (id == null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				_dbContext.Remove(visitor);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}


			}
			return View(visitor);

		}




	}

}

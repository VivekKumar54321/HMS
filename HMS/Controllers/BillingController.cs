using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.DatabaseConnection;
using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HMS.Controllers
{
	public class BillingController : Controller
	{
		protected readonly HMSContext _dbContext;

		public BillingController(HMSContext dbcontext)
		{
			_dbContext = dbcontext;
		}

		// Billing ko list show gareko Index ma ie LIST show gareko 
		public async Task<IActionResult> Index()
		{
			 var billing = await _dbContext.Billing.Include(X=>X.Visitor).ToListAsync();
			return View(billing);
		}

		[HttpGet]
		public IActionResult Create()
		{
		
			var visitorname = _dbContext.Visitor.ToList();
			ViewBag.Visitor = visitorname.Select(X => new SelectListItem
			{
				Text = X.VisitorName.ToString(),
				Value = X.VisitorId.ToString()
			});

			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Create([Bind("BillingType, BillingDate, BillingAmount, VisitorId")] Billing billing)
		{
			if (ModelState.IsValid)
			{
				_dbContext.Add(billing);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(billing);

		}

		[HttpGet]
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				var visitors = _dbContext.Visitor.ToList();
				ViewBag.Visitor = visitors.Select(X => new SelectListItem
				{
					Text = X.VisitorName,
					Value = X.VisitorId.ToString()
				});
				
				var billing = await _dbContext.Billing.FindAsync(id);
				return View(billing);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Edit(int? id, Billing billing)
		{
			if (ModelState.IsValid)
			{
				if (id == null)
				{
					return RedirectToAction(nameof(Index));
				}
				else
				{
					_dbContext.Update(billing);
					await _dbContext.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}

			}
			return View(billing);
		}
		[HttpGet]
		public async Task<IActionResult> Details(int? id)
		{
			var billing = await _dbContext.Billing.FindAsync(id);
		
			var visitor = await _dbContext.Visitor.FindAsync(billing.VisitorId);
			billing.VisitorId = visitor.VisitorId;

			return View(billing);

		}



		[HttpGet]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{

				var billing = await _dbContext.Billing.FindAsync(id);
				
				var visitor = await _dbContext.Visitor.FindAsync(billing.VisitorId);
				billing.VisitorId = visitor.VisitorId;

				return View(billing);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Delete(Billing billing)
		{


			if (billing == null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				_dbContext.Remove(billing);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
				//return View(billing);
			}


		}
	}
}


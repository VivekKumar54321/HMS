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
	public class MiscellaneousBillingController : Controller
	{
		protected readonly HMSContext _dbContext;

		public MiscellaneousBillingController(HMSContext dbcontext)
		{
			_dbContext = dbcontext;
		}

		// MiscellaneousBillingController ko list show gareko Index ma ie LIST show gareko (LIST VIEW )
		public async Task<IActionResult> Index()
		{
			var miscellaneousbilling = await _dbContext.MiscellaneousBilling.Include(X => X.Visitor).ToListAsync();
			return View(miscellaneousbilling);
		}


		

		// Create ko View lai display gareko GET le 
		[HttpGet]
		public IActionResult Create()
		{

			var visitors = _dbContext.Visitor.ToList();
			visitors.Insert(0, new Visitor { VisitorId = 0, VisitorName = "Select" });
			ViewBag.Visitors = visitors;
			//return View(model.TotalAmount);
			return View();
		}

		// Create ko view ma rakehko value  lai save gareko POST le 
		[HttpPost]

		public async Task<IActionResult> Create([Bind("MiscellaneousBillingId, Food, FoodRate, RoomServiceCharge, ServiceTax, TotalAmount, VisitorId")] MiscellaneousBilling miscellaneousbilling)
		{
			if (miscellaneousbilling.VisitorId == 0)
			{
				var visitors = _dbContext.Visitor.ToList();
				visitors.Insert(0, new Visitor { VisitorId = 0, VisitorName = "Select" });
				ViewBag.Visitors = visitors;
				ModelState.AddModelError("VisitorId", "Please select the Visitor Name");
				return View(miscellaneousbilling);
			}
			if (ModelState.IsValid)
			{

				_dbContext.Add(miscellaneousbilling);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(miscellaneousbilling);

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
				visitors.Insert(0, new Visitor { VisitorId = 0, VisitorName = "Select" });
				ViewBag.Visitors = visitors;
				var miscellaneousbilling = await _dbContext.MiscellaneousBilling.FindAsync(id);
				return View(miscellaneousbilling);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Edit(int? id, MiscellaneousBilling miscellaneousbilling)
		{
			if (miscellaneousbilling.VisitorId == 0)
			{
				var visitors = _dbContext.Visitor.ToList();
				visitors.Insert(0, new Visitor { VisitorId = 0, VisitorName = "Select" });
				ViewBag.Visitors = visitors;
				ModelState.AddModelError("VisitorId", "Please select the Visitor Name");
				return View(miscellaneousbilling);
			}
			if (ModelState.IsValid)
			{
				if (id == null)
				{
					return RedirectToAction(nameof(Index));
				}
				else
				{
					_dbContext.Update(miscellaneousbilling);
					await _dbContext.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}

			}
			return View(miscellaneousbilling);
		}
		[HttpGet]
		public async Task<IActionResult> Details(int? id)
		{
			var miscellaneousbilling = await _dbContext.MiscellaneousBilling.FindAsync(id);
			var visitor = await _dbContext.Visitor.FindAsync(miscellaneousbilling.VisitorId);
			miscellaneousbilling.Visitor = visitor;
			return View(miscellaneousbilling);

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

				var miscellaneousbilling = await _dbContext.MiscellaneousBilling.FindAsync(id);
				var visitor = await _dbContext.Visitor.FindAsync(miscellaneousbilling.VisitorId);
				miscellaneousbilling.Visitor = visitor;
				return View(miscellaneousbilling);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Delete(MiscellaneousBilling miscellaneousbilling)
		{


			if (miscellaneousbilling == null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				_dbContext.Remove(miscellaneousbilling);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
				//return View(billing);
			}


		}
	}
}
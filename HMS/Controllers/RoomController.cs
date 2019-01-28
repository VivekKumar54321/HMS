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
	public class RoomController : Controller
	{
		protected readonly HMSContext _dbContext;

		public RoomController(HMSContext dbcontext)
		{
			_dbContext = dbcontext;
		}

		// Room ko list show gareko Index ma ie LIST show gareko 
		public async Task<IActionResult> Index()
		{
			var room = await _dbContext.Room.ToListAsync();
			return View(room);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Create([Bind("RoomNo, RoomType, RoomRate")] Room room)
		{
			if (ModelState.IsValid)
			{
				_dbContext.Add(room);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(room);

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
				var room = await _dbContext.Room.FindAsync(id);
				return View(room);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Edit(int? id, Room room)
		{
			if (ModelState.IsValid)
			{
				if (id == null)
				{
					return RedirectToAction(nameof(Index));
				}
				else
				{
					_dbContext.Update(room);
					await _dbContext.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}

			}
			return View(room);
		}
		[HttpGet]
		public async Task<IActionResult> Details(int? id)
		{

			var room = await _dbContext.Room.FindAsync(id);
			return View(room);

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
				var room = await _dbContext.Room.FindAsync(id);
				return View(room);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Delete(int? id, Room room)
		{
			if (ModelState.IsValid)
			{
				if (id == null)
				{
					return RedirectToAction(nameof(Index));
				}
				else
				{
					_dbContext.Remove(room);
					await _dbContext.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}
			}
			return View(room);
		}
	}
}
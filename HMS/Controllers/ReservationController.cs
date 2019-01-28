using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.DatabaseConnection;
using HMS.Models;
using HMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HMS.Controllers
{
	public class ReservationController : Controller
	{
		protected readonly HMSContext _dbContext;

		public ReservationController(HMSContext dbcontext)
		{
			_dbContext = dbcontext;
		}

		// Reservation ko list show gareko Index ma ie LIST show gareko 
		public async Task<IActionResult> Index()
		{
			var reservation = await _dbContext.Reservation.Include(X => X.Room).Include(X => X.Billing).Include(X=>X.Visitor).Include(X => X.MiscellaneousBilling).ToListAsync();
			
			return View(reservation);
		}

		[HttpGet]
		public IActionResult Create()
		{
			var visitors = _dbContext.Visitor.ToList();
			visitors.Insert(0, new Visitor { VisitorId = 0, VisitorName = "Select VisitorName" });
			ViewBag.Visitor = visitors;


			//var visitors = _dbContext.Visitor.ToList();
			//ViewBag.Visitors = visitors.Select(X => new SelectListItem
			//{
			//	Text = X.VisitorName,
			//	Value = X.VisitorId.ToString()
			//});

			var rooms = _dbContext.Room.ToList();
			rooms.Insert(0, new Room { RoomId = 0, RoomNo="Select RoomNo" });
			ViewBag.Room = rooms;


			//var rooms = _dbContext.Room.ToList();
			//ViewBag.Rooms = rooms.Select(X => new SelectListItem
			//{
			//	Text = X.RoomNo.ToString(),
			//	Value = X.RoomId.ToString()
			//});


			var billings = _dbContext.Billing.ToList();
			billings.Insert(0, new Billing { BillingId = 0, BillingType = "Select" });
			ViewBag.Billings = billings;

			//var billings = _dbContext.Billing.ToList();
			//ViewBag.Billings = billings.Select(X => new SelectListItem
			//{

			//	Text = X.BillingType,
			//	Value = X.BillingId.ToString()

			//});



			var billingsdate = _dbContext.Billing.ToList();
			ViewBag.Billingsdate = billingsdate.Select(X => new SelectListItem
			{

				Text = X.BillingDate.ToLongDateString(),
				Value = X.BillingId.ToString()

			});



			var billingsamount = _dbContext.Billing.ToList();
			ViewBag.Billingsamount = billingsamount.Select(X => new SelectListItem
			{

				Text = X.BillingAmount.ToString(),
				Value = X.BillingId.ToString()

			});
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Create( ReservationViewModel reservationVM)
		{
			
				if (reservationVM.VisitorId == 0)
				{
					var visitors = _dbContext.Visitor.ToList();
					visitors.Insert(0, new Visitor { VisitorId = 0, VisitorName = "Select VIsitorName" });
					ViewBag.Visitor = visitors;
					ModelState.AddModelError("VisitorId", "Select Visitor Name");
					return View(reservationVM);
				}
				if (reservationVM.RoomId == 0)
				{
					var rooms = _dbContext.Room.ToList();
					rooms.Insert(0, new Room { RoomId = 0, RoomNo = "Select RoomNo" });
					ViewBag.Room = rooms;
					ModelState.AddModelError("RoomId", "Select Room No");
					return View(reservationVM);
				}
				if (reservationVM.BillingId == 0)
				{
					var billings = _dbContext.Billing.ToList();
					billings.Insert(0, new Billing { BillingId = 0, BillingType = "Select Billing Type" });
					ViewBag.Billings = billings;
					ModelState.AddModelError("BillingId", "Select Billing Type");
					return View(reservationVM);
				}
			if (ModelState.IsValid)
			{

				if (reservationVM.CheckInDate <= reservationVM.CheckOutDate)
				{
					var reservation = new Reservation
					{
						CheckInDate = reservationVM.CheckInDate,
						CheckOutDate = reservationVM.CheckOutDate,
						GrandTotal = reservationVM.GrandTotal,
						RoomBooked = reservationVM.RoomBooked,
						BillingId =  reservationVM.BillingId,
						RoomId = reservationVM.RoomId,
						VisitorId=reservationVM.VisitorId,
						MiscellaneousBillingId= reservationVM.MiscellaneousBillingId
					};
					
					_dbContext.Add(reservation);
					await _dbContext.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}
				else
				{
					return BadRequest("Check Out date must be greater than Checkin date ");
				}

			}
			return View(reservationVM);

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
				var rooms = _dbContext.Room.ToList();
				ViewBag.Visitors = visitors.Select(X => new SelectListItem
				{
					Text = X.VisitorName,
					Value = X.VisitorId.ToString()
				});
				ViewBag.Rooms = rooms.Select(X => new SelectListItem
				{
					Text = X.RoomNo.ToString(),
					Value = X.RoomId.ToString()
				});
				var billings = _dbContext.Billing.ToList();
				ViewBag.Billings = billings.Select(X => new SelectListItem
				{

					Text = X.BillingType,
					Value = X.BillingId.ToString()

				});
				var billingsdate = _dbContext.Billing.ToList();
				ViewBag.Billingsdate = billingsdate.Select(X => new SelectListItem
				{

					Text = X.BillingDate.ToLongDateString(),
					Value = X.BillingId.ToString()

				});
				var billingsamount = _dbContext.Billing.ToList();
				ViewBag.Billingsamount = billingsamount.Select(X => new SelectListItem
				{

					Text = X.BillingAmount.ToString(),
					Value = X.BillingId.ToString()

				});
				var reservation = await _dbContext.Reservation.FindAsync(id);
				return View(reservation);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Edit(int? id, Reservation reservation)
		{
			if (ModelState.IsValid)
			{
				if (id == null)
				{
					return RedirectToAction(nameof(Index));
				}
				else
				{
					_dbContext.Update(reservation);
					await _dbContext.SaveChangesAsync();
					return RedirectToAction(nameof(Index));
				}

			}
			return View(reservation);
		}
		[HttpGet]
		public async Task<IActionResult> Details(int? id)
		{
			var reservation = await _dbContext.Reservation.FindAsync(id);
			var visitor = await _dbContext.Visitor.FindAsync(reservation.VisitorId);
			reservation.Visitor = visitor;
			var room = await _dbContext.Room.FindAsync(reservation.RoomId);
			reservation.Room = room;
			var billing = await _dbContext.Billing.FindAsync(reservation.BillingId);
			reservation.Billing = billing;
			return View(reservation);

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
				var reservation = await _dbContext.Reservation.FindAsync(id);
				var visitor = await _dbContext.Visitor.FindAsync(reservation.VisitorId);
				reservation.Visitor = visitor;
				var room = await _dbContext.Room.FindAsync(reservation.RoomId);
				reservation.Room = room;
				var billing = await _dbContext.Billing.FindAsync(reservation.BillingId);
				reservation.Billing = billing;
				return View(reservation);
			}

		}
		[HttpPost]
		public async Task<IActionResult> Delete(int? id, Reservation reservation)
		{

			if (id == null)
			{
				return RedirectToAction(nameof(Index));
			}
			else
			{
				_dbContext.Remove(reservation);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}	
		}

	}
}
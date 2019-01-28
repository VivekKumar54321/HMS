using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
			public ContentResult Index(FormCollection formCollection)
			{
				int userId = int.Parse(formCollection["UserId"]);
			string name = formCollection["Name"];
			string address = formCollection["Address"];
			string phonenumber = formCollection["PhoneNumber"];

			string message = "UserId: " + userId;
			message += "\nName: " + name;
			message += "\nAddress: " + address;
			message += "\nPhoneNumber: " + phonenumber;
			return Content(message);
		}




		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

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
    public class Serve : Controller
    {
		
		
        public IActionResult Index()
        {
			
            return View();
        }


		public IActionResult Create()
		{

			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}








	}

}

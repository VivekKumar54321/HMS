using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Models
{
	public class Login
	{
		public int LoginId { get; set; }

		[Required(ErrorMessage = "Enter the  Username")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Enter the  Password")]
		[MaxLength(50, ErrorMessage = "Too Long Number")]
		public string Password { get; set; }
		public string Bishal { get; set; }
		public string Vivek { get; set; }
		
	}
}

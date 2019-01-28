using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Models
{
	public class Visitor
	{
		
		public int VisitorId { get; set; }
		[Required( ErrorMessage = "Enter the  Name of Visitor")]
		public string VisitorName { get; set; }
		[Required(ErrorMessage = "Enter the  Address of Visitor")]

		public string VisitorAddress { get; set; }
		[Required(ErrorMessage = "Enter the  Phone Number of Visitor ")]
		[MaxLength(50, ErrorMessage = "Too Long Number")]

		public string VisitorPhoneNo { get; set; }
		[Required(ErrorMessage = "Enter the  Email of Visitor ")]

		public string VisitorEmail { get; set; }

	}
}

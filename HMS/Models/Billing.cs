using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Models
{
	public class Billing
	{

		public int BillingId { get; set; }
		[Required(ErrorMessage = "Enter the Billing Type")]
		public string BillingType { get; set; }
		[Required(ErrorMessage = "Enter the Billing Date")]
		public DateTime BillingDate { get; set; }
		[Required(ErrorMessage = "Enter the Billing Amount")]
		public double BillingAmount { get; set; }



		public Visitor Visitor { get; set; }
		public int VisitorId { get; set; }

	}
}

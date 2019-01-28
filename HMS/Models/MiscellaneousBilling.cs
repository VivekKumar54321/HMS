using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Models
{
	public class MiscellaneousBilling
	{
		public int MiscellaneousBillingId { get; set; }
		public string Food { get; set; }
		public double FoodRate { get; set; }
		public double RoomServiceCharge { get; set;}
		public double ServiceTax { get; set; }
		public double TotalAmount { get; set; }

		public Visitor Visitor { get; set; }
		public int VisitorId { get; set; }

	}
}

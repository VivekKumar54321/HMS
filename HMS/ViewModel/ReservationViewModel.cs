using HMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.ViewModel
{
	public class ReservationViewModel
	{
		public int ReservationId { get; set; }
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime CheckInDate { get; set; }

		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime CheckOutDate { get; set; }
		public int RoomBooked { get; set; }
		public double GrandTotal { get; set; }
		public Billing Billing { get; set; }
		public int BillingId { get; set; }
		public int VisitorId { get; set; }
		public int RoomId { get; set; }

		public MiscellaneousBilling MiscellaneousBilling { get; set; }
		public int MiscellaneousBillingId { get; set; }

	}
}

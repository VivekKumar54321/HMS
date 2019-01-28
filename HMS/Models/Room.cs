using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Models
{
	public class Room
	{
		public int RoomId { get; set; }
		[Required(ErrorMessage ="Enter the RoomNo")]
		public string RoomNo { get; set; }
		[Required(ErrorMessage = "Enter the RoomType")]

		public string RoomType { get; set; }
		[Required(ErrorMessage = "Enter the RoomRate")]
		public string RoomRate { get; set; }

	}
}

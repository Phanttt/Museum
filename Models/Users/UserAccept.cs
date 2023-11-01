using System.ComponentModel.DataAnnotations;

namespace Museum.Models.Users
{
	public class UserAccept
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
		public string? password { get; set; }
		public int roleId { get; set; }
	}
}

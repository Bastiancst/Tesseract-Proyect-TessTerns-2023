using System.ComponentModel.DataAnnotations;

namespace ferreteria_backend.Models.DTO
{
	public class ItemDTO
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]

		public string Name { get; set; }
		[Required]
		public int Price { get; set; }
		[Required]
		public string ImageUrl { get; set; }
		public string Description { get; set; }
	}
}

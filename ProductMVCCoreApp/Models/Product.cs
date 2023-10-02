using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMVCCoreApp.Models
{
	public class Product
	{
		public Product()
		{
		}

		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public int Price { get; set; }
	}
}


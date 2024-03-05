using System.ComponentModel.DataAnnotations;

namespace DataflowWebApi.Models
{
	public class Products
	{
		[Key]
		public int ProductId { get; set; }
		public string ProductName { get; set; } = string.Empty;
		public string ProdcutCategory { get; set; } = string.Empty;
        public double ProductPrice { get; set; }
		public string CodeBar { get; set; } = string.Empty;
	}
}

using DataflowWebApi.Data;
using DataflowWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataflowWebApi.Controllers
{
	[ApiController]
	[Route("/api/[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly DataContext _context;
		public ProductsController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetAsync()
		{
			return Ok(await _context.Products.ToListAsync());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAsync(int id)
		{
			var product = await _context.Products.FindAsync(id);

			if (product == null)
			{
				return NotFound();
			}

			return Ok(product);
		}

		[HttpPost]
		public async Task<IActionResult> PostAsync(Products product)
		{
			_context.Products.Add(product);
			await _context.SaveChangesAsync();
			return Ok(product);
		}

		[HttpPut]
		public async Task<IActionResult> PutAsync(Products product)
		{
			_context.Products.Update(product);
			await _context.SaveChangesAsync();
			return Ok(product);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAsync(int id) 
		{
			var productDelete = await _context.Products.FindAsync(id);
			if (productDelete == null) 
			{
				return NotFound();
			}
			_context.Remove(productDelete);
			await _context.SaveChangesAsync();
			return NoContent();
		}	
    }
}

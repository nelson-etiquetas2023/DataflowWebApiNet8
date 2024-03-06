using DataflowWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DataflowWebApi.Data
{
	public class DataContext: DbContext
	{
#pragma warning disable IDE0290 // Usar constructor principal
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
#pragma warning restore IDE0290 // Usar constructor principal
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}

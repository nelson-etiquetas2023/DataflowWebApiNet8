﻿using DataflowWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DataflowWebApi.Data
{
	public class DataContext: DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}

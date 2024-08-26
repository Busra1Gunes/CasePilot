using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IUMMNFO\SQLEXPRESS;Initial Catalog=StockWise;Integrated Security=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS;Initial Catalog=StockWise;Integrated Security=True;Trust Server Certificate=True");
			optionsBuilder.UseSqlServer("Data Source=AYZASOFT-0000;Initial Catalog=StockWise;Integrated Security=True;Trust Server Certificate=True");

		}
		DbSet<User> Users { get; set; }
		DbSet<Stock> Stocks { get; set; }
		DbSet<Supplier> Suppliers { get; set; }

	}
}

using Microsoft.EntityFrameworkCore;
using NetCoreLAB6_EF.Models;

namespace NetCoreLAB6_EF.Data
{
	public class NvtAppDbContext : DbContext
	{
		public NvtAppDbContext(DbContextOptions<NvtAppDbContext> options)
			: base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }
	}
}
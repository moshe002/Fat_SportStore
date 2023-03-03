using Microsoft.EntityFrameworkCore;

namespace Fat_SportStore.Models
{
	public class StoreDbContext : DbContext
	{
		public StoreDbContext(DbContextOptions<StoreDbContext> options) 
			: base(options) { }
		public DbSet<Product> Products => Set<Product>();
	}
}

using Microsoft.EntityFrameworkCore;

namespace NetCoreTemplate.Models.Context
{
	public class Db : DbContext
	{
		// register tables
		// public DbSet<Name> Name { get; set; }

		public Db(DbContextOptions<Db> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// set defaults and model/column settings:

			// e.g.

			// builder.Entity<object>()
			// 	.HasMany(h => h.Employees)
			// 	.WithOne(w => w.Company)
			// 	.OnDelete(DeleteBehavior.Cascade);

			// builder.Entity<config.models.PendingTask>()
			// 	.Property(p => p.CreateDate)
			// 	.HasDefaultValueSql("getdate()");
		}
	}
}

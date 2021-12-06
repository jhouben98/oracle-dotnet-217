using Microsoft.EntityFrameworkCore;

namespace oracle_dotnet_217
{
	public class TestDbContext : DbContext
	{
		public DbSet<Test> TEST { get; set; }

		public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("TESTSCHEMA");
			modelBuilder.Model.SetMaxIdentifierLength(30);

			modelBuilder.Entity<Test>(entity =>
			{
				entity.Property(p => p.Id).UseIdentityColumn();

				entity.HasKey(p => p.Id);
			});
		}
	}
}
